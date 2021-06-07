using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneActivityVariant
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("completionStatus")]
        public DestinyMilestoneActivityCompletionStatus CompletionStatus { get; set; }
        [JsonProperty("activityModeHash")]
        public UInt32 ActivityModeHash { get; set; }
        [JsonProperty("activityModeType")]
        public Int32 ActivityModeType { get; set; }
    }
}
