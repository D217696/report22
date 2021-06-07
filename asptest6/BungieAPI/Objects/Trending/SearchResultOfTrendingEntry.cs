using Newtonsoft.Json;
using NiobeLab.Core.Objects.Queries;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class SearchResultOfTrendingEntry
    {
        [JsonProperty("results")]
        public TrendingEntry[] Results { get; set; }
        [JsonProperty("totalResults")]
        public Int32 TotalResults { get; set; }
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
        [JsonProperty("query")]
        public PagedQuery Query { get; set; }
        [JsonProperty("replacementContinuationToken")]
        public string ReplacementContinuationToken { get; set; }
        [JsonProperty("useTotalResult")]
        public bool UseTotalResult { get; set; }
    }
}
