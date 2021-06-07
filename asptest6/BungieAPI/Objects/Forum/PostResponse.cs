using Newtonsoft.Json;
using NiobeLab.Core.Objects.Ignores;
using System;

namespace NiobeLab.Core.Objects.Forum
{
    public class PostResponse
    {
        [JsonProperty("lastReplyTimestamp")]
        public DateTime LastReplyTimestamp { get; set; }
        [JsonProperty("isPinned")]
        public bool IsPinned { get; set; }
        [JsonProperty("urlMediaType")]
        public Int32 UrlMediaType { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("popularity")]
        public Int32 Popularity { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        [JsonProperty("isAnnouncement")]
        public bool IsAnnouncement { get; set; }
        [JsonProperty("userRating")]
        public Int32 UserRating { get; set; }
        [JsonProperty("userHasRated")]
        public bool UserHasRated { get; set; }
        [JsonProperty("userHasMutedPost")]
        public bool UserHasMutedPost { get; set; }
        [JsonProperty("lastReplyPostId")]
        public Int64 LastReplyPostId { get; set; }
        [JsonProperty("latestReplyAuthorId")]
        public Int64 LatestReplyAuthorId { get; set; }
        [JsonProperty("ignoreStatus")]
        public IgnoreResponse IgnoreStatus { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}
