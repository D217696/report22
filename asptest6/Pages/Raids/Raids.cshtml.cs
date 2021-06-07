using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using asptest6.Models;
using asptest6.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Endpoints;
using NiobeLab.Core.Objects.Destiny.HistoricalStats;
using NiobeLab.Core.Objects.Destiny.Responses;

namespace asptest6.Pages.Forms
{
    public class RaidsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int MembershipType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MembershipId { get; set; }

        public new User User { get; set; }
        public List<Profile> Profiles { get; set; } = new List<Profile>();

        public async void OnGet()
        {
            ProfilesModel ProfileModel = new ProfilesModel();
            BungieApi BungieApi = new BungieApi();
            UsersModel UsersModel = new UsersModel();
            CharactersModel CharactersModel = new CharactersModel();

            Profiles = ProfileModel.GetProfiles(MembershipId);
            if (Profiles.Count > 0)
            {
                User = UsersModel.GetUser(Profiles[0].UserId);
                foreach(Profile profile in Profiles)
                {
                    profile.Characters = CharactersModel.GetCharacters(profile.MembershipId);
                }
            }
            else
            {
                GetLinkedProfiles getLinkedProfiles = JsonConvert.DeserializeObject<GetLinkedProfiles>(await BungieApi.MakeRequest($"/Destiny2/{MembershipType}/Profile/{MembershipId}/LinkedProfiles/"));
                if (getLinkedProfiles.ErrorCode != 1) return;

                User = UsersModel.InsertUser(getLinkedProfiles.Response.Profiles[0].DisplayName);
                foreach(DestinyProfileUserInfoCard profile in getLinkedProfiles.Response.Profiles)
                {
                    Profiles.Add(ProfileModel.InsertProfile(new Profile
                    {
                        MembershipId = profile.MembershipId.ToString(),
                        MembershipType = profile.MembershipType,
                        UserId = User.UserID,
                        LastUpdated = new DateTime(2017, 9, 1),
                        Username = profile.DisplayName
                    }));

                    GetHistoricalStatsForAccount getHistoricalStatsForAccount = JsonConvert.DeserializeObject<GetHistoricalStatsForAccount>( await BungieApi.MakeRequest($"/Destiny2/{profile.MembershipType}/Account/{profile.MembershipId}/Stats/"));
                    if (getHistoricalStatsForAccount.ErrorCode != 1) return;

                    foreach (DestinyHistoricalStatsPerCharacter character in getHistoricalStatsForAccount.Response.Characters)
                    {
                        CharactersModel.InsertCharacter(new Character
                        {
                            CharacterId = character.CharacterId.ToString(),
                            MembershipId = profile.MembershipId.ToString(),
                            Deleted = character.Deleted
                        });
                    }
                }

                foreach (Profile profile in Profiles)
                {
                    profile.Characters = CharactersModel.GetCharacters(profile.MembershipId);
                }
            }
        }

        public JsonResult OnPostTest()
        {
            Console.WriteLine(new StreamReader(HttpContext.Request.Body).ReadToEnd());
            Console.WriteLine("reached");
            return new JsonResult(Profiles);
        }
    }

    public class model
    {
        List<Profile> profiles { get; set; } 
    }
}
