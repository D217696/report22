using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneRewardEntry
    {
        [JsonProperty("rewardEntryHash")]
        public UInt32 RewardEntryHash { get; set; }
        [JsonProperty("earned")]
        public bool Earned { get; set; }
        [JsonProperty("redeemed")]
        public bool Redeemed { get; set; }
    }
}
