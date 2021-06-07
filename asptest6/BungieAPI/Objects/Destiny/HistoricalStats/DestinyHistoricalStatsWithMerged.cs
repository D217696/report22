using Newtonsoft.Json;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsWithMerged
    {
        [JsonProperty("results")]
        public Dictionary<string, DestinyHistoricalStatsByPeriod> Results { get; set; }
        [JsonProperty("merged")]
        public DestinyHistoricalStatsByPeriod Merged { get; set; }
    }
}
