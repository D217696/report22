using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.User
{
    public class HardLinkedUserMembership
    {
        [JsonProperty("membershipType")]
        public Int32 MembershipType { get; set; }
        [JsonProperty("membershipId")]
        public Int64 MembershipId { get; set; }
        [JsonProperty("CrossSaveOverriddenType")]
        public Int32 CrossSaveOverriddenType { get; set; }
        [JsonProperty("CrossSaveOverriddenMembershipId")]
        public Int64 CrossSaveOverriddenMembershipId { get; set; }
    }
}
