using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyProgressionStepDefinition
    {
        [JsonProperty("stepName")]
        public string StepName { get; set; }
        [JsonProperty("displayEffectType")]
        public Int32 DisplayEffectType { get; set; }
        [JsonProperty("progressTotal")]
        public Int32 ProgressTotal { get; set; }
        [JsonProperty("rewardItems")]
        public DestinyItemQuantity[] RewardItems { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
