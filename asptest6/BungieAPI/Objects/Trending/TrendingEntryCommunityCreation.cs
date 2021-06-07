using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingEntryCommunityCreation
    {
        [JsonProperty("media")]
        public string Media { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("authorMembershipId")]
        public Int64 AuthorMembershipId { get; set; }
        [JsonProperty("postId")]
        public Int64 PostId { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("upvotes")]
        public Int32 Upvotes { get; set; }
    }
}
