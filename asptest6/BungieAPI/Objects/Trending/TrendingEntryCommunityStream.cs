using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingEntryCommunityStream
    {
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("partnershipIdentifier")]
        public string PartnershipIdentifier { get; set; }
        [JsonProperty("partnershipType")]
        public Int32 PartnershipType { get; set; }
    }
}
