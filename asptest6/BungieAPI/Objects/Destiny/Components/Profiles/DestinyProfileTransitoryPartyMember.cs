using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Profiles
{
    public class DestinyProfileTransitoryPartyMember
    {
        [JsonProperty("membershipId")]
        public Int64 MembershipId { get; set; }
        [JsonProperty("emblemHash")]
        public UInt32 EmblemHash { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("status")]
        public Int32 Status { get; set; }
    }
}
