using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemInvestmentStatDefinition
    {
        [JsonProperty("statTypeHash")]
        public UInt32 StatTypeHash { get; set; }
        [JsonProperty("value")]
        public Int32 Value { get; set; }
        [JsonProperty("isConditionallyActive")]
        public bool IsConditionallyActive { get; set; }
    }
}
