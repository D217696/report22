using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingEntry
    {
        [JsonProperty("weight")]
        public double Weight { get; set; }
        [JsonProperty("isFeatured")]
        public bool IsFeatured { get; set; }
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        [JsonProperty("entityType")]
        public Int32 EntityType { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("tagline")]
        public string Tagline { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("webmVideo")]
        public string WebmVideo { get; set; }
        [JsonProperty("mp4Video")]
        public string Mp4Video { get; set; }
        [JsonProperty("featureImage")]
        public string FeatureImage { get; set; }
        [JsonProperty("items")]
        public TrendingEntry[] Items { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
    }
}
