using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyPublicMilestoneChallenge
    {
        [JsonProperty("objectiveHash")]
        public UInt32 ObjectiveHash { get; set; }
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
    }
}
