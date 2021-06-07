using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneActivity
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivtyHash { get; set; }
        [JsonProperty("activityModeHash")]
        public UInt32 ActivityModeHash { get; set; }
        [JsonProperty("activityModeType")]
        public Int32 ActivityModeType { get; set; }
        [JsonProperty("modifierHashes")]
        public UInt32[] ModiierHashes { get; set; }
        [JsonProperty("variants")]
        public DestinyMilestoneActivityVariant[] Variants { get; set; }
    }
}