using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingEntryDestinyItem
    {
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
    }
}
