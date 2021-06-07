using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupFeatures
    {
        [JsonProperty("maximumMembers")]
        public Int32 MaximumMembers { get; set; }
        [JsonProperty("maximumMembershipsOfGroupType")]
        public Int32 MaximumMembershipsOfGroupType { get; set; }
        [JsonProperty("capabilities")]
        public Int32 Capabilities { get; set; }
        [JsonProperty("membershipTypes")]
        public Int32[] MembershipType { get; set; }
        [JsonProperty("invitePermissionOverride")]
        public bool InvitePermissionOverride { get; set; }
        [JsonProperty("updateCulturePermissionOverride")]
        public bool UpdateCulturePermissionOverride { get; set; }
        [JsonProperty("hostGuidedGamePermissionOverride")]
        public Int32 HostGuidedGamePermissionOverride { get; set; }
        [JsonProperty("updateBannerPermissionOverride")]
        public bool UpdateBannerPermissionOverride { get; set; }
        [JsonProperty("joinLevel")]
        public Int32 JoinLevel { get; set; }
    }
}
