using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingCategories
    {
        [JsonProperty("categories")]
        public TrendingCategory[] Categories { get; set; }
    }
}
