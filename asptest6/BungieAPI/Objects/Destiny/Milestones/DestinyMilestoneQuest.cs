using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Challenges;
using NiobeLab.Core.Objects.Destiny.Quests;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneQuest
    {
        [JsonProperty("questItemHash")]
        public UInt32 QuestItemHash { get; set; }
        [JsonProperty("status")]
        public DestinyQuestStatus Status { get; set; }
        [JsonProperty("activity")]
        public DestinyMilestoneActivity Activity { get; set; }
        [JsonProperty("challenges")]
        public DestinyChallengeStatus[] Challenges { get; set; }
    }
}
