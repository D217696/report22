using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyPublicMilestone
    {
        [JsonProperty("milestoneHash")]
        public UInt32 MilestoneHash { get; set; }
        [JsonProperty("availableQuests")]
        public DestinyPublicMilestoneQuest[] AvailableQuests { get; set; }
        [JsonProperty("activities")]
        public DestinyPublicMilestoneChallengeActivity[] Activities { get; set; }
        [JsonProperty("vendorHashes")]
        public UInt32[] VendorHashes { get; set; }
        [JsonProperty("vendors")]
        public DestinyPublicMilestoneVendor[] Vendors { get; set; }
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
        [JsonProperty("order")]
        public Int32 Order { get; set; }
    }
}
