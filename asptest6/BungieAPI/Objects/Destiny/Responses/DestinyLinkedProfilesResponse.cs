using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyLinkedProfilesResponse
    {
        [JsonProperty("profiles")]
        public DestinyProfileUserInfoCard[] Profiles { get; set; }
        [JsonProperty("bnetMembership")]
        public UserInfoCard BnetMembership { get; set; }
        [JsonProperty("profilesWithErrors")]
        public DestinyErrorProfile[] ProfilesWithErros { get; set; }
    }
}
