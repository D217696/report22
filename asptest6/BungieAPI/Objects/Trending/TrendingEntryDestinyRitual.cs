using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Milestones;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingEntryDestinyRitual
    {
        [JsonProperty("iamge")]
        public string Image { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
        [JsonProperty("dateStart")]
        public DateTime DateStart { get; set; }
        [JsonProperty("dateEnd")]
        public DateTime DateEnd { get; set; }
        [JsonProperty("milestoneDetails")]
        public DestinyPublicMilestone MilestoneDetails { get; set; }
        [JsonProperty("eventContent")]
        public DestinyMilestoneContent EventContent { get; set; }
    }
}
