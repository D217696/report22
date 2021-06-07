using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneActivityCompletionStatus
    {
        [JsonProperty("completed")]
        public bool Completed { get; set; }
        [JsonProperty("phases")]
        public DestinyMilestoneActivityPhase[] Phases { get; set; }
    }
}
