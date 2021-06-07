using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Fireteam
{
    public class FireteamUserInfoCard
    {
        [JsonProperty("FireteamDisplayName")]
        public string FireteamDisplayName { get; set; }
        [JsonProperty("FireteamMembershipType")]
        public Int32 FireteamMembershipType { get; set; }
        [JsonProperty("FireteamPlatformProfileUrl")]
        public string FireteamPlatformProfileUrl { get; set; }
        [JsonProperty("FireteamPlatformUniqueIdentifier")]
        public string FireteamPlatformUniqueIdentifier { get; set; }
        [JsonProperty("supplementalDisplayName")]
        public string SupplementalDisplayName { get; set; }
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("crossSaveOverride")]
        public Int32 CrossSaveOverride { get; set; }
        [JsonProperty("applicableMembershipTypes")]
        public Int32[] ApplicableMembershipTypes { get; set; }
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
        [JsonProperty("membershipType")]
        public Int32 MembershipType { get; set; }
        [JsonProperty("membershipId")]
        public Int64 MembershipId { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
