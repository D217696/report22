using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Advanced
{
    public class AwaAuthorizationResult
    {
        [JsonProperty("userSelection")]
        public Int32 UserSelection { get; set; }
        [JsonProperty("resposneReason")]
        public Int32 ResponseReason { get; set; }
        [JsonProperty("developerNote")]
        public string DeveloperNote { get; set; }
        [JsonProperty("actionToken")]
        public string ActionToken { get; set; }
        [JsonProperty("maximumNumberOfUses")]
        public Int32 MaximumNumberOfUses { get; set; }
        [JsonProperty("validUntil")]
        public DateTime ValidUntil { get; set; }
        [JsonProperty("type")]
        public Int32 Type { get; set; }
        [JsonProperty("membershipType")]
        public Int32 MembershipType { get; set; }
    }
}
