using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemActionBlockDefinition
    {
        [JsonProperty("verbName")]
        public string VerbName { get; set; }
        [JsonProperty("verbDescription")]
        public string VerbDescription { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
        [JsonProperty("overlayScreenName")]
        public string OverlayScreenName { get; set; }
        [JsonProperty("overlayIcon")]
        public string OverlayIcon { get; set; }
        [JsonProperty("requiredCooldownSeconds")]
        public Int32 RequiredCooldownSeconds { get; set; }
        [JsonProperty("requiredItems")]
        public DestinyItemActionRequiredItemDefinition[] RequiredItems { get; set; }
        [JsonProperty("progressionRewards")]
        public DestinyProgressionRewardDefinition[] ProgressionRewards { get; set; }
        [JsonProperty("actionTypeLabel")]
        public string ActionTypeLabel { get; set; }
        [JsonProperty("requiredLocation")]
        public string RequiredLocation { get; set; }
        [JsonProperty("requiredCooldownHash")]
        public UInt32 RequiredCooldownHash { get; set; }
        [JsonProperty("deleteOnAction")]
        public bool DeleteOnAction { get; set; }
        [JsonProperty("consumeEntireStack")]
        public bool ConsumeEntireStack { get; set; }
        [JsonProperty("useOnAcquire")]
        public bool UseOnAcquire { get; set; }
    }
}
