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
        [HttpPost]
        public async Task<List<Profile>> PostProfile(List<Profile> profiles)
        {
            BungieApi bungieApi = new();
            ActivityPagesModel activityPagesModel = new();

            foreach (Profile profile in profiles)
            {
                foreach(Character character in profile.Characters)
                {
                    bool done = false;
                    int i = 0;

                    while (!done)
                    {
                        GetActivityHistory getActivityHistory = JsonConvert.DeserializeObject<GetActivityHistory>(await bungieApi.MakeRequest($"/Destiny2/{profile.MembershipType}/Account/{profile.MembershipId}/Character/{character.CharacterId}/Stats/Activities/?mode=4&count=250&page={i}"));
                        if (getActivityHistory.ErrorCode != 1) return null;

                        if (getActivityHistory.Response.Activities == null)
                        {
                            done = true;
                            continue;
                        }

                        activityPagesModel.InsertActivityPage(new ActivityPage
                        {
                            Json = JsonConvert.SerializeObject(getActivityHistory.Response.Activities),
                            MembershipId = profile.MembershipId,
                            CharacterId = character.CharacterId,
                            StartDate = getActivityHistory.Response.Activities[0].Period,
                            EndDate = getActivityHistory.Response.Activities[^1].Period,
                            Count = getActivityHistory.Response.Activities.Length,
                            Page = i
                        });

                        if (getActivityHistory.Response.Activities.Length < 250) done = true;
                        i++;
                    }
                }
            }
            return profiles;
        }
    }
}
