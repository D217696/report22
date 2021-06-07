using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyEntitySearchResult
    {
        [JsonProperty("suggestedWords")]
        public string[] SuggestedWords { get; set; }
        [JsonProperty("results")]
        public SearchResultOfDestinyEntitySearchResultItem[] Results { get; set; }
    }
}
