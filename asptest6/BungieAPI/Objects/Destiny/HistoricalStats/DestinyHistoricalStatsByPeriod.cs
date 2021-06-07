using Newtonsoft.Json;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsByPeriod
    {
        [JsonProperty("allTime")]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTime { get; set; }
        [JsonProperty("allTimeTier1")]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTimeTier1 { get; set; }
        [JsonProperty("allTimeTier2")]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTimeTier2 { get; set; }
        [JsonProperty("allTimeTier3")]
        public Dictionary<string, DestinyHistoricalStatsValue> AllTimeTier3 { get; set; }
        [JsonProperty("daily")]
        public DestinyHistoricalStatsPeriodGroup[] Daily { get; set; }
        [JsonProperty("monthly")]
        public DestinyHistoricalStatsPeriodGroup[] Monthly { get; set; }
    }
}
