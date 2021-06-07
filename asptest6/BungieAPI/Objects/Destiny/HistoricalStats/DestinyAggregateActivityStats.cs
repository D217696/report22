using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyAggregateActivityStats
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("values")]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }
    }
}
