using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Activities
{
    public class DestinyPublicActivityStatus
    {
        [JsonProperty("challengeObjectiveHashes")]
        public UInt32[] ChallengeObjectiveHashes { get; set; }
        [JsonProperty("modifierHashes")]
        public UInt32[] ModifierHashes { get; set; }
        [JsonProperty("rewardTooltipItems")]
        public DestinyItemQuantity[] RewardTooltipItems { get; set; }
    }
}
