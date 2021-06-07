using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityRewardDefinition
    {
        [JsonProperty("rewardText")]
        public string RewardText { get; set; }
        [JsonProperty("rewardItems")]
        public DestinyItemQuantity[] RewardItems { get; set; }
    }
}
