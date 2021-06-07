using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyClanAggregateStat
    {
        [JsonProperty("mode")]
        public Int32 Mode { get; set; }
        [JsonProperty("statId")]
        public string StatId { get; set; }
        [JsonProperty("value")]
        public DestinyHistoricalStatsValue Value { get; set; }
    }
}
