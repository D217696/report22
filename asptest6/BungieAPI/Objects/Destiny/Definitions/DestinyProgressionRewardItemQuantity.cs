using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyProgressionRewardItemQuantity
    {
        [JsonProperty("rewardedAtProgressionLevel")]
        public Int32 RewardedAtProgressionLevel { get; set; }
        [JsonProperty("acquisitionBehavior")]
        public Int32 AcquisitionBehavior { get; set; }
        [JsonProperty("uiDisplayStyle")]
        public string UiDisplayStyle { get; set; }
        [JsonProperty("claimUnlockDisplayStrings")]
        public string[] ClaimUnlockDisplayStrings { get; set; }
        [JsonProperty("itemHash")]
        public Int32 ItemHash { get; set; }
        [JsonProperty("itemInstanceId")]
        public Int64 ItemInstanceId { get; set; }
        [JsonProperty("quantity")]
        public Int32 Quantity { get; set; }
    }
}
