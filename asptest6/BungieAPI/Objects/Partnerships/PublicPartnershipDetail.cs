using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Partnerships
{
    public class PublicPartnershipDetail
    {
        [JsonProperty("partnerType")]
        public Int32 PartnerType { get; set; }
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
