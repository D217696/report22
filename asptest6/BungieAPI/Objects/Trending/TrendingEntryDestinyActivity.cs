using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Activities;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingEntryDestinyActivity
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("status")]
        public DestinyPublicActivityStatus Status { get; set; }
    }
}
