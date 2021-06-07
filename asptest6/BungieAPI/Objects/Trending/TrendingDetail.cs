using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingDetail
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        [JsonProperty("entityType")]
        public Int32 EntityType { get; set; }
        [JsonProperty("news")]
        public TrendingEntryNews News { get; set; }
        [JsonProperty("support")]
        public TrendingEntrySupportArticle Support { get; set; }
        [JsonProperty("destinyItem")]
        public TrendingEntryDestinyItem DestinyItem { get; set; }
        [JsonProperty("destinyActivity")]
        public TrendingEntryDestinyActivity DestinyActivity { get; set; }
        [JsonProperty("destinyRitual")]
        public TrendingEntryDestinyRitual DestinyRitual { get; set; }
        [JsonProperty("creation")]
        public TrendingEntryCommunityCreation Creation { get; set; }
        [JsonProperty("stream")]
        public TrendingEntryCommunityStream Stream { get; set; }
    }
}
