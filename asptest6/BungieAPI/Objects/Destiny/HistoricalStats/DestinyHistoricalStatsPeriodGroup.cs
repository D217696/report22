using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsPeriodGroup
    {
        [JsonProperty("period")]
        public DateTime Period { get; set; }
        [JsonProperty("activityDetails")]
        public DestinyHistoricalStatsActivity ActivityDetails { get; set; }
        [JsonProperty("values")]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }
    }
}
