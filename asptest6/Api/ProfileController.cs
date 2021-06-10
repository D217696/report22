using asptest6.Models;
using asptest6.Objects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Endpoints;
using NiobeLab.Core.Objects.Destiny.HistoricalStats;
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
        readonly ActivityPagesModel ActivityPagesModel = new();
        readonly ProfilesModel profilesModel = new();
        readonly CharacterPgcrModel characterPgcrModel = new();
        readonly PgcrsModel pgcrsModel = new();
        readonly BungieApi BungieApi = new();

        [HttpPost("CharacterPages")]
        public async Task<GetCharacterPagesResponse> GetCharacterPages(List<Profile> profiles)
        {
            Console.WriteLine("getting character pages");
            List<Task<CharacterPageRequest>> tasks = new();
            GetCharacterPagesResponse getCharacterPagesResponse = new();
            bool succeeded = true;

            foreach (Profile profile in profiles)
            {
                foreach(Character character in profile.Characters)
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

                foreach(ActivityPage activityPage in task.Result.ActivtityPages)
                {
                    getCharacterPagesResponse.Count += activityPage.Count;
                    getCharacterPagesResponse.Pages++;
                    ActivityPagesModel.InsertActivityPage(activityPage);
                }
            }

            if (succeeded)
            {
                foreach(Profile profile in profiles)
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
                GetActivityHistory getActivityHistory = JsonConvert.DeserializeObject<GetActivityHistory>(await BungieApi.MakeRequest($"/Destiny2/{membershipType}/Account/{membershipId}/Character/{characterId}/Stats/Activities/?mode=4&count=250&page={i}"));
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
            ActivityPage activityPage = ActivityPagesModel.GetActivityPage(characterPage.MembershipId, characterPage.CharacterId, characterPage.Pages - 1);
            DestinyHistoricalStatsPeriodGroup[] activities = JsonConvert.DeserializeObject<DestinyHistoricalStatsPeriodGroup[]>(activityPage.Json).Where(x => x.Values["completed"].Basic.Value == 1 && x.Values["completionReason"].Basic.DisplayValue == "Objective Completed").ToArray(); //completion check
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
                    GetPostGameCarnageReport getPostGameCarnageReport = JsonConvert.DeserializeObject<GetPostGameCarnageReport>(pgcr.Pcgr);

                    DestinyPostGameCarnageReportEntry player = (DestinyPostGameCarnageReportEntry)getPostGameCarnageReport.Response.Entries.Where(x => x.CharacterId.ToString() == characterPage.CharacterId);

                    CharacterPgcr characterPgcr = new()
                    {
                        CharacterId = characterPage.CharacterId,
                        PgcrId = activity.ActivityDetails.InstanceId,
                        Kills = (int)player.Values["kills"].Basic.Value,
                        Deaths = (int)player.Values["deaths"].Basic.Value,
                        Completed = player.Values["completed"].Basic.Value == 1
                    };

                    characterPgcrModel.InsertCharacterPgcr(characterPgcr);
                }
            }

            await Task.WhenAll(tasks.ToArray());
            foreach (Task<GetPGCRResponse> task in tasks)
            {
                if (task.Result.ErrorCode != 1) continue;
                GetPGCRResponse getPCGRResponse = task.Result;

                characterPgcrModel.InsertCharacterPgcr(getPCGRResponse.CharacterPgcr);
                Pgcr pgcr = pgcrsModel.GetPgcr(getPCGRResponse.Pgcr.PcgrId);
                if (pgcr != null) continue;
                pgcrsModel.InsertPgcr(getPCGRResponse.Pgcr);
            }

            characterPage.Pages -= 1;
            return characterPage;
        }

        public async Task<GetPGCRResponse> RequestAndVerifyPCGR(long activityId, string characterId)
        {
            GetPGCRResponse getPCGRResponse = new();
            GetPostGameCarnageReport getPostGameCarnageReport = JsonConvert.DeserializeObject<GetPostGameCarnageReport>(await BungieApi.MakeRequestWithoutBaseUrl($"https://stats.bungie.net/Platform/Destiny2/Stats/PostGameCarnageReport/{activityId}/"));
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
            bool completed = false;

            foreach(DestinyPostGameCarnageReportEntry entry in getPostGameCarnageReport.Response.Entries)
            {
                totalDeaths += (int)entry.Values["deaths"].Basic.Value;
                totalKills += (int)entry.Values["kills"].Basic.Value;
                if (entry.Values["kills"].Basic.Value > 0 && entry.Values["assists"].Basic.Value > 0) playerCount++;

                if (entry.CharacterId.ToString() == characterId)
                {
                    playerKills = (int)entry.Values["kills"].Basic.Value;
                    playerDeaths = (int)entry.Values["deaths"].Basic.Value;
                    completed = entry.Values["completed"].Basic.Value == 1;
                }
            }

            getPCGRResponse.CharacterPgcr = new()
            {
                CharacterId = characterId,
                PgcrId = activityId,
                Kills = playerKills, 
                Deaths = playerDeaths,
                Completed = completed 
            };

            getPCGRResponse.Pgcr = new()
            { 
                PcgrId = activityId,
                Pcgr = JsonConvert.SerializeObject(getPostGameCarnageReport),
                Flawless = totalDeaths == 0,
                StartingPhaseIndex = getPostGameCarnageReport.Response.StartingPhaseIndex,
                PlayerCount = playerCount, 
                RaidId = 1
            };

            getPCGRResponse.ErrorCode = 1;
            getPCGRResponse.ErrorMessage = "success";

            return getPCGRResponse;
        }
    }
}
