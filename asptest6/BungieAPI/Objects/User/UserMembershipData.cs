using Newtonsoft.Json;
using NiobeLab.Core.Objects.GroupsV2;

namespace NiobeLab.Core.Objects.User
{
    public class UserMembershipData
    {
        [JsonProperty("destinyMemberships")]
        public GroupUserInfoCard[] DestinyMemberships { get; set; }
        [JsonProperty("bungieNetUser")]
        public GeneralUser BungieNetUser { get; set; }
    }
}
