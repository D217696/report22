using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsValue
    {
        [JsonProperty("statId")]
        public string StatId { get; set; }
        [JsonProperty("basic")]
        public DestinyHistoricalStatsValuePair Basic { get; set; }
        [JsonProperty("pga")]
        public DestinyHistoricalStatsValuePair Pga { get; set; }
        [JsonProperty("weighted")]
        public DestinyHistoricalStatsValuePair Weighted { get; set; }
        [JsonProperty("activityId")]
        public Int64 ActivityId { get; set; }
    }
}
