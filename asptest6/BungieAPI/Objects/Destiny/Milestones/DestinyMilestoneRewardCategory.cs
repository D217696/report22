using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneRewardCategory
    {
        [JsonProperty("rewardCategoryHash")]
        public UInt32 RewardCategoryHash { get; set; }
        [JsonProperty("entries")]
        public DestinyMilestoneRewardEntry[] Entries { get; set; }
    }
}
