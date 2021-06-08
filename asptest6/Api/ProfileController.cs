using asptest6.Models;
using asptest6.Objects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Endpoints;
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
        readonly BungieApi BungieApi = new();

        [HttpPost]
        public async Task<GetCharacterPagesResponse> GetCharacterPages(List<Profile> profiles)
        {
            List<Task<CharacterPageRequest>> tasks = new();
            GetCharacterPagesResponse getCharacterPagesResponse = new GetCharacterPagesResponse();

            foreach (Profile profile in profiles)
            {
                foreach(Character character in profile.Characters)
                {
                     tasks.Add(Task.Run(() => GetCharacterPage(profile.MembershipType, profile.MembershipId, character.CharacterId)));
                }
            }

            await Task.WhenAll(tasks.ToArray());
            foreach (Task<CharacterPageRequest> task in tasks)
            {
                getCharacterPagesResponse.Characters.Add(new CharacterPage()
                {
                    CharacterId = task.Result.CharacterId,
                    Count = task.Result.Count,
                    ErrorCode = task.Result.Count,
                    ErrorMessage = task.Result.ErrorMessage,
                    Pages = task.Result.Pages
                });

                foreach(ActivityPage activityPage in task.Result.ActivtityPages)
                {
                    ActivityPagesModel.InsertActivityPage(activityPage);
                }
            }

            return getCharacterPagesResponse;
        }

        public async Task<CharacterPageRequest> GetCharacterPage(int membershipType, string membershipId, string characterId)
        {
            bool done = false;
            int i = 0;
            int count = 0;
            CharacterPageRequest characterPageRequest = new()
            {
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
            characterPageRequest.Pages = i +1;
            return characterPageRequest;
        }
    }
}
