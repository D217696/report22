using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyPublicMilestoneActivityVariant
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("activityModeHash")]
        public UInt32 ActivityModeHash { get; set; }
        [JsonProperty("activityModeType")]
        public Int32 ActivityModeType { get; set; }
    }
}
