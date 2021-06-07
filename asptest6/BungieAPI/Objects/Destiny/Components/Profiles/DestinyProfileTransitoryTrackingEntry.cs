using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Profiles
{
    public class DestinyProfileTransitoryTrackingEntry
    {
        [JsonProperty("locationHash")]
        public UInt32 LocationHash { get; set; }
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("objectiveHash")]
        public UInt32 ObjectiveHash { get; set; }
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("questlineItemHash")]
        public UInt32 QuestlineItemHash { get; set; }
        [JsonProperty("trackedDate")]
        public DateTime TrackedDate { get; set; }
    }
}
