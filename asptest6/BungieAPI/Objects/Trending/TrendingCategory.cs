using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingCategory
    {
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
        [JsonProperty("entries")]
        public SearchResultOfTrendingEntry Entries { get; set; }
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }
    }
}
