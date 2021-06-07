using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyPublicMilestoneActivity
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("modifierHashes")]
        public UInt32[] ModifierHashes { get; set; }
        [JsonProperty("variants")]
        public DestinyPublicMilestoneActivityVariant[] Variants { get; set; }
        [JsonProperty("activityModeHash")]
        public UInt32 ActivityModeHash { get; set; }
        [JsonProperty("activityModeType")]
        public Int32 ActivityModeType { get; set; }
    }
}
