using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyProgressionRewardDefinition
    {
        [JsonProperty("progressionMappingHash")]
        public UInt32 ProgressionMappingHash { get; set; }
        [JsonProperty("amount")]
        public Int32 Amount { get; set; }
        [JsonProperty("applyThrottles")]
        public bool ApplyThrottles { get; set; }
    }
}
