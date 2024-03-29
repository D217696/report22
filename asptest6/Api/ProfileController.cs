﻿using asptest6.Models;
using asptest6.Objects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Endpoints;
using NiobeLab.Core.Objects.Destiny.Entities.Characters;
using NiobeLab.Core.Objects.Destiny.HistoricalStats;
using NiobeLab.Core.Objects.Destiny.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Api
{
    [Route("api/[controller]", Name = nameof(ProfileController))]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        readonly ActivityPagesModel activityPagesModel = new();
        readonly ProfilesModel profilesModel = new();
        readonly CharacterPgcrModel characterPgcrModel = new();
        readonly CharactersModel charactersModel = new();
        readonly PgcrsModel pgcrsModel = new();
        readonly RaidsModel raidsModel = new();
        readonly UsersModel usersModel = new();
        readonly BungieApi bungieApi = new();


        [HttpPost("GetProfileAndUpdateCharacters")]
        public async Task<GetProfileResponse> GetProfilesAndUpdateCharacters(Credentials credentials)
        {
            GetProfileResponse getProfileResponse = new();

            getProfileResponse.Profiles = profilesModel.GetProfiles(credentials.MembershipId);
            if (getProfileResponse.Profiles.Count > 0)
            {
                getProfileResponse.User = usersModel.GetUser(getProfileResponse.Profiles[0].UserId);


                foreach (Profile profile in getProfileResponse.Profiles)
                {
                    GetProfile getProfile = JsonConvert.DeserializeObject<GetProfile>(await bungieApi.MakeRequest($"/Destiny2/{profile.MembershipType}/Profile/{profile.MembershipId}/?components=100,200"));
                    if (getProfile.ErrorCode != 1)
                    {
                        getProfileResponse.ErrorCode = getProfile.ErrorCode;
                        getProfileResponse.ErrorMessage = getProfile.Message;
                        return getProfileResponse;
                    }

                    //get characters that will be updated
                    getProfileResponse.Profiles.Where(x => x.MembershipId == profile.MembershipId.ToString()).First().Characters = charactersModel.GetCharactersToUpdate(getProfile.Response.Characters.Data.Keys.ToList(), getProfile.Response.Profile.Data.UserInfo.MembershipId.ToString());
                    if (getProfileResponse.Profiles.Where(x => x.MembershipId == profile.MembershipId.ToString()).First().Characters.Count > 0)
                    {
                        //update the characters
                        charactersModel.UpdateCharacters(getProfile.Response.Characters.Data.Keys.ToList(), getProfile.Response.Profile.Data.UserInfo.MembershipId.ToString());
                    }

                    foreach (DestinyCharacterComponent destinyCharacterComponent in getProfile.Response.Characters.Data.Values)
                    {
                        //get other characters
                        if (destinyCharacterComponent.DateLastPlayed >= getProfileResponse.Profiles.Where(x => x.MembershipId == profile.MembershipId).First().LastUpdated)
                        {
                            getProfileResponse.Profiles.Where(x => x.MembershipId == profile.MembershipId.ToString()).First().Characters.Add(new Character()
                            {
                                CharacterId = destinyCharacterComponent.CharacterId.ToString(),
                                MembershipId = profile.MembershipId.ToString(),
                                Deleted = false
                            });
                        }
                    }
                }
            }
            else
            {
                GetLinkedProfiles getLinkedProfiles = JsonConvert.DeserializeObject<GetLinkedProfiles>(await bungieApi.MakeRequest($"/Destiny2/{credentials.MembershipType}/Profile/{credentials.MembershipId}/LinkedProfiles/"));
                if (getLinkedProfiles.ErrorCode != 1)
                {
                    getProfileResponse.ErrorCode = getLinkedProfiles.ErrorCode;
                    getProfileResponse.ErrorMessage = getLinkedProfiles.Message;
                    return getProfileResponse;
                }

                getProfileResponse.User = usersModel.InsertUser(getLinkedProfiles.Response.Profiles[0].DisplayName);
                foreach (DestinyProfileUserInfoCard profile in getLinkedProfiles.Response.Profiles)
                {
                    getProfileResponse.Profiles.Add(profilesModel.InsertProfile(new Profile
                    {
                        MembershipId = profile.MembershipId.ToString(),
                        MembershipType = profile.MembershipType,
                        UserId = getProfileResponse.User.UserID,
                        LastUpdated = new DateTime(2017, 9, 1),
                        Username = profile.DisplayName
                    }));

                    GetHistoricalStatsForAccount getHistoricalStatsForAccount = JsonConvert.DeserializeObject<GetHistoricalStatsForAccount>(await bungieApi.MakeRequest($"/Destiny2/{profile.MembershipType}/Account/{profile.MembershipId}/Stats/"));
                    if (getHistoricalStatsForAccount.ErrorCode != 1)
                    {
                        getProfileResponse.ErrorCode = getLinkedProfiles.ErrorCode;
                        getProfileResponse.ErrorMessage = getLinkedProfiles.Message;
                        return getProfileResponse;
                    }

                    foreach (DestinyHistoricalStatsPerCharacter character in getHistoricalStatsForAccount.Response.Characters)
                    {
                        getProfileResponse.Profiles.Where(x => x.MembershipId == profile.MembershipId.ToString()).First().Characters.Add(charactersModel.InsertCharacter(new Character() {
                            CharacterId = character.CharacterId.ToString(),
                            MembershipId = profile.MembershipId.ToString(),
                            Deleted = character.Deleted
                        }));
                    }
                }
            }

            return getProfileResponse;
        }

        [HttpPost("CharacterPages")]
        public async Task<GetCharacterPagesResponse> GetCharacterPages(List<Profile> profiles)
        {
            Console.WriteLine("getting character pages");
            List<Task<CharacterPageRequest>> tasks = new();
            GetCharacterPagesResponse getCharacterPagesResponse = new();
            bool succeeded = true;

            foreach (Profile profile in profiles)
            {
                foreach (Character character in profile.Characters)
                {
                    tasks.Add(Task.Run(() => GetCharacterPage(profile.MembershipType, profile.MembershipId, character.CharacterId, profile.LastUpdated)));
                }
            }

            await Task.WhenAll(tasks.ToArray());
            foreach (Task<CharacterPageRequest> task in tasks)
            {
                if (task.Result.ErrorCode != 1) succeeded = false;
                getCharacterPagesResponse.Characters.Add(new CharacterPage()
                {
                    MembershipId = task.Result.MembershipId,
                    CharacterId = task.Result.CharacterId,
                    Count = task.Result.Count,
                    ErrorCode = task.Result.ErrorCode,
                    ErrorMessage = task.Result.ErrorMessage,
                    Pages = task.Result.Pages
                });

                foreach (ActivityPage activityPage in task.Result.ActivtityPages)
                {
                    getCharacterPagesResponse.Count += activityPage.Count;
                    getCharacterPagesResponse.Pages++;
                    activityPagesModel.InsertActivityPage(activityPage);
                }
            }

            if (succeeded)
            {
                foreach (Profile profile in profiles)
                {
                    profilesModel.UpdateProfileLastUpdated(profile.MembershipId, DateTime.UtcNow.AddDays(-1));
                }
            }

            return getCharacterPagesResponse;
        }

        public async Task<CharacterPageRequest> GetCharacterPage(int membershipType, string membershipId, string characterId, DateTime lastUpdated)
        {
            bool done = false;
            int i = 0;
            int count = 0;
            CharacterPageRequest characterPageRequest = new()
            {
                MembershipId = membershipId,
                CharacterId = characterId,
                Count = 0,
                Pages = 0,
                ErrorCode = 1,
                ErrorMessage = "Success"
            };

            while (!done)
            {
                GetActivityHistory getActivityHistory = JsonConvert.DeserializeObject<GetActivityHistory>(await bungieApi.MakeRequest($"/Destiny2/{membershipType}/Account/{membershipId}/Character/{characterId}/Stats/Activities/?mode=4&count=250&page={i}"));
                if (getActivityHistory.ErrorCode != 1)
                {
                    characterPageRequest.ErrorCode = getActivityHistory.ErrorCode;
                    characterPageRequest.ErrorMessage = getActivityHistory.Message;
                    return characterPageRequest;
                }

                if (getActivityHistory.Response.Activities == null)
                {
                    done = true;
                    continue;
                }

                if (getActivityHistory.Response.Activities[^1].Period < lastUpdated)
                {
                    DestinyHistoricalStatsPeriodGroup[] results = getActivityHistory.Response.Activities.Where(x => x.Period > lastUpdated).ToArray();
                    if (results.Length > 0)
                    {
                        getActivityHistory.Response.Activities = results;
                        characterPageRequest.ActivtityPages.Add(new ActivityPage
                        {
                            Json = JsonConvert.SerializeObject(getActivityHistory.Response.Activities),
                            MembershipId = membershipId,
                            CharacterId = characterId,
                            StartDate = results[0].Period,
                            EndDate = results[^1].Period,
                            Count = results.Length,
                            Page = i
                        });
                        i++;
                        count += results.Length;
                    }

                    done = true;
                    continue;
                }

                characterPageRequest.ActivtityPages.Add(new ActivityPage
                {
                    Json = JsonConvert.SerializeObject(getActivityHistory.Response.Activities),
                    MembershipId = membershipId,
                    CharacterId = characterId,
                    StartDate = getActivityHistory.Response.Activities[0].Period,
                    EndDate = getActivityHistory.Response.Activities[^1].Period,
                    Count = getActivityHistory.Response.Activities.Length,
                    Page = i
                });

                if (getActivityHistory.Response.Activities.Length < 250) done = true;
                i++;
                count += getActivityHistory.Response.Activities.Length;
            }

            characterPageRequest.Count = count;
            characterPageRequest.Pages = i;
            return characterPageRequest;
        }

        [HttpPost("PcgrsPage")]
        public async Task<CharacterPage> RequestPCGRs(CharacterPage characterPage)
        {
            Console.WriteLine("getting pcgrs");
            raidsModel.LoadRaidHashes();
            ActivityPage activityPage = activityPagesModel.GetActivityPage(characterPage.MembershipId, characterPage.CharacterId, characterPage.Pages - 1);
            DestinyHistoricalStatsPeriodGroup[] unfilteredActivites = JsonConvert.DeserializeObject<DestinyHistoricalStatsPeriodGroup[]>(activityPage.Json);
            DestinyHistoricalStatsPeriodGroup[] activities = unfilteredActivites.Where(x => x.Values["completed"].Basic.Value == 1 && x.Values["completionReason"].Basic.DisplayValue == "Objective Completed").ToArray(); //completion check
            List<Task<GetPGCRResponse>> tasks = new(); //response from get pcgr and lowman algorithm

            foreach (DestinyHistoricalStatsPeriodGroup activity in activities)
            {
                Pgcr pgcr = pgcrsModel.GetPgcr(activity.ActivityDetails.InstanceId);
                GetPGCRResponse getPGCRResponse = await RequestAndVerifyPCGR(activity.ActivityDetails.InstanceId, characterPage.CharacterId);
                if (pgcr == null)
                {
                    tasks.Add(Task.Run(() => RequestAndVerifyPCGR(activity.ActivityDetails.InstanceId, characterPage.CharacterId)));
                }
                else
                {
                    GetPostGameCarnageReport getPostGameCarnageReport = JsonConvert.DeserializeObject<GetPostGameCarnageReport>(pgcr.PgcrString);

                    DestinyPostGameCarnageReportEntry player = null;

                    foreach (DestinyPostGameCarnageReportEntry entry in getPostGameCarnageReport.Response.Entries)
                    {
                        if (entry.CharacterId.ToString() == characterPage.CharacterId)
                        {
                            player = entry;
                            break;
                        }
                    }

                    CharacterPgcr characterPgcr = new()
                    {
                        CharacterId = characterPage.CharacterId,
                        pgcrId = activity.ActivityDetails.InstanceId,
                        Kills = (int)player.Values["kills"].Basic.Value,
                        Deaths = (int)player.Values["deaths"].Basic.Value,
                        Completed = player.Values["completed"].Basic.Value == 1
                    };

                    CharacterPgcr characterPgcrFromDB = characterPgcrModel.GetCharacterPgcr(characterPage.CharacterId, activity.ActivityDetails.InstanceId);
                    if (characterPgcrFromDB == null)
                    {
                        characterPgcrModel.InsertCharacterPgcr(characterPgcr);
                    }
                }
            }

            await Task.WhenAll(tasks.ToArray());
            foreach (Task<GetPGCRResponse> task in tasks)
            {
                if (task.Result.ErrorCode != 1) continue;
                GetPGCRResponse getPGCRResponse = task.Result;

                CharacterPgcr characterPgcr = characterPgcrModel.GetCharacterPgcr(getPGCRResponse.CharacterPgcr.CharacterId, getPGCRResponse.CharacterPgcr.pgcrId);
                if (characterPgcr == null) characterPgcrModel.InsertCharacterPgcr(getPGCRResponse.CharacterPgcr);

                Pgcr pgcr = pgcrsModel.GetPgcr(getPGCRResponse.Pgcr.pgcrId);
                if (pgcr != null) continue;
                pgcrsModel.InsertPgcr(getPGCRResponse.Pgcr);
            }

            activityPagesModel.UpdateActivityPageHandled(activityPage.Id, true);
            characterPage.Count = unfilteredActivites.Length;
            return characterPage;
        }

        public async Task<GetPGCRResponse> RequestAndVerifyPCGR(long activityId, string characterId)
        {
            GetPGCRResponse getPCGRResponse = new();
            GetPostGameCarnageReport getPostGameCarnageReport = JsonConvert.DeserializeObject<GetPostGameCarnageReport>(await bungieApi.MakeRequestWithoutBaseUrl($"https://stats.bungie.net/Platform/Destiny2/Stats/PostGameCarnageReport/{activityId}/"));
                      
            if (getPostGameCarnageReport.ErrorCode != 1)
            {
                return new GetPGCRResponse()
                {
                    ErrorCode = getPostGameCarnageReport.ErrorCode,
                    ErrorMessage = getPostGameCarnageReport.Message
                };
            }

            int totalKills = 0;
            int totalDeaths = 0;
            int playerCount = 0;
            int playerKills = 0;
            int playerDeaths = 0;
            int timeInSeconds = 0;
            bool completed = false;

            foreach (DestinyPostGameCarnageReportEntry entry in getPostGameCarnageReport.Response.Entries)
            {
                totalDeaths += (int)entry.Values["deaths"].Basic.Value;
                totalKills += (int)entry.Values["kills"].Basic.Value;
                if (entry.Values["kills"].Basic.Value > 0 || entry.Values["assists"].Basic.Value > 0) playerCount++;

                if (entry.CharacterId.ToString() == characterId)
                {
                    playerKills = (int)entry.Values["kills"].Basic.Value;
                    playerDeaths = (int)entry.Values["deaths"].Basic.Value;
                    completed = entry.Values["completed"].Basic.Value == 1;
                    timeInSeconds = (int)entry.Values["activityDurationSeconds"].Basic.Value;
                }
            }

            if (playerCount == 0) completed = false;

            getPCGRResponse.CharacterPgcr = new()
            {
                CharacterId = characterId,
                pgcrId = activityId,
                Kills = playerKills,
                Deaths = playerDeaths,
                Completed = completed
            };

            getPCGRResponse.Pgcr = new()
            {
                pgcrId = activityId,
                PgcrString = JsonConvert.SerializeObject(getPostGameCarnageReport),
                Flawless = totalDeaths == 0,
                StartingPhaseIndex = getPostGameCarnageReport.Response.StartingPhaseIndex,
                PlayerCount = playerCount,
                RaidId = raidsModel.RaidHashes[getPostGameCarnageReport.Response.ActivityDetails.ReferenceId],
                TimeInSeconds = timeInSeconds
            };

            getPCGRResponse.ErrorCode = 1;
            getPCGRResponse.ErrorMessage = "success";

            return getPCGRResponse;
        }

        [HttpPost("ProfileRaids")]
        public async Task<ProfileRaidCompletions> GetProfileRaids(Profile profile)
        {
            ProfileRaidCompletions profileRaidCompletions = new();
            List<Raid> raids = raidsModel.GetRaids();
            List<Completion> completions = characterPgcrModel.GetCompletions(profile.MembershipId); //pgcr
            List<RaidCompletions> raidCompletions = new();
            foreach (Raid raid in raids)
            {
                List<Completion> completionsForRaid = completions.Where(x => x.RaidId == raid.RaidId).ToList();
                raidCompletions.Add(new RaidCompletions
                {
                    Raid = raid,
                    ThreeMans = completionsForRaid.Where(x => x.PlayerCount == 3).Count(),
                    TwoMans = completionsForRaid.Where(x => x.PlayerCount == 2).Count(),
                    OneMans = completionsForRaid.Where(x => x.PlayerCount == 1).Count(),
                    Completions = completionsForRaid
                });
            }
            profileRaidCompletions.Profile = profile;
            profileRaidCompletions.RaidCompletions = raidCompletions.GroupBy(x => x.Raid.DisplayName).Select(d => new RaidCompletions
            {
                OneMans = d.Sum(x => x.OneMans),
                TwoMans = d.Sum(x => x.TwoMans),
                ThreeMans = d.Sum(x => x.ThreeMans),
                Completions = d.SelectMany(x => x.Completions).ToList(),
                Raid = d.FirstOrDefault().Raid
            }).OrderByDescending(x => x.Raid.ReleaseDate).ToList();
            return profileRaidCompletions;
        }

        [HttpPost("GetPgcr")]
        public async Task<GetPostGameCarnageReport> GetPgcr(string id)
        {
            string pgcrString = pgcrsModel.GetPgcr(long.Parse(id)).PgcrString;
            if (pgcrString != null)
            {
                return JsonConvert.DeserializeObject<GetPostGameCarnageReport>(pgcrString);
            }

            return JsonConvert.DeserializeObject<GetPostGameCarnageReport>(await bungieApi.MakeRequestWithoutBaseUrl($"https://stats.bungie.net/Platform/Destiny2/Stats/PostGameCarnageReport/{id}/"));
        }
    }
}

public class Id
{
    public long Id2 { get; set; }
}