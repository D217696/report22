using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupUserInfoCard
    {
        [JsonProperty("LastSeenDisplayName")]
        public string LastSeenDisplayName { get; set; }
        [JsonProperty("LastSeenDisplayNameType")]
        public Int32 LastSeenDisplayNameType { get; set; }
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
