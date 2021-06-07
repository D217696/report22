using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestone
    {
        [JsonProperty("milestoneHash")]
        public UInt32 MilestoneHash { get; set; }
        [JsonProperty("availableQuests")]
        public DestinyMilestoneQuest[] AvailableQuests { get; set; }
        [JsonProperty("activities")]
        public DestinyMilestoneChallengeActivity[] Activities { get; set; }
        [JsonProperty("values")]
        public Dictionary<string, float> Values { get; set; }
        [JsonProperty("vendorHashes")]
        public UInt32[] VendorHashes { get; set; }
        [JsonProperty("vendors")]
        public DestinyMilestoneVendor[] Vendors { get; set; }
        [JsonProperty("rewards")]
        public DestinyMilestoneRewardCategory[] Rewards { get; set; }
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
        [JsonProperty("order")]
        public Int32 Order { get; set; }
    }
}
