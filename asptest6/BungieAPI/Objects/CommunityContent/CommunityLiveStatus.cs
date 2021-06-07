using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.CommunityContent
{
    public class CommunityLiveStatus
    {
        [JsonProperty("dateStatusUpdated")]
        public DateTime DateStatusUpdated { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("partnershipIdentifier")]
        public string PartnershipIdentifier { get; set; }
        [JsonProperty("partnershipType")]
        public Int32 PartnershipType { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("thumbnailSmall")]
        public string ThumbnailSmall { get; set; }
        [JsonProperty("thumbnailLarge")]
        public string ThumbnailLarge { get; set; }
        [JsonProperty("destinyCharacterId")]
        public Int64 DestinyCharacterId { get; set; }
        [JsonProperty("userInfo")]
        public UserInfoCard UserInfo { get; set; }
        [JsonProperty("currentActivityHash")]
        public UInt32 CurrentActivityHash { get; set; }
        [JsonProperty("dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }
        [JsonProperty("dateStreamStarted")]
        public DateTime DateStreamStarted { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("currentViewers")]
        public Int32 CurrentViewers { get; set; }
        [JsonProperty("followers")]
        public Int32 Followers { get; set; }
        [JsonProperty("overallViewers")]
        public Int32 OverallViewers { get; set; }
        [JsonProperty("isFeatured")]
        public bool IsFeatured { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("activityModeHash")]
        public UInt32 ActivityModeHash { get; set; }
        [JsonProperty("dateFeatured")]
        public DateTime DateFeatured { get; set; }
        [JsonProperty("trendingValue")]
        public float TrendingValue { get; set; }
        [JsonProperty("isSubscribable")]
        public bool IsSubscribable { get; set; }
    }
}
