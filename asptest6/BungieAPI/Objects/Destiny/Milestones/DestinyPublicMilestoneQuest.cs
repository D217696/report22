using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyPublicMilestoneQuest
    {
        [JsonProperty("questItemHash")]
        public UInt32 QuestItemHash { get; set; }
        [JsonProperty("activity")]
        public DestinyPublicMilestoneActivity Activity { get; set; }
        [JsonProperty("challenges")]
        public DestinyPublicMilestoneChallenge[] Challenges { get; set; }
    }
}
