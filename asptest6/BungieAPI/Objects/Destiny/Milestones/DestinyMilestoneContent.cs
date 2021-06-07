using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneContent
    {
        [JsonProperty("about")]
        public string About { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("tips")]
        public string[] Tips { get; set; }
        [JsonProperty("itemCategories")]
        public DestinyMilestoneContentItemCategory[] ItemCategories { get; set; }
    }
}
