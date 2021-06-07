using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Quests
{
    public class DestinyObjectiveProgress
    {
        [JsonProperty("objectiveHash")]
        public UInt32 ObjectiveHash { get; set; }
        [JsonProperty("destinationHash")]
        public UInt32 DestinationHash { get; set; }
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("progress")]
        public Int32 Progress { get; set; }
        [JsonProperty("completionValue")]
        public Int32 CompletionValue { get; set; }
        [JsonProperty("complete")]
        public bool Complete { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}