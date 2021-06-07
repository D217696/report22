using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyPostGameCarnageReportEntry
    {
        [JsonProperty("standing")]
        public Int32 Standing { get; set; }
        [JsonProperty("score")]
        public DestinyHistoricalStatsValue Score { get; set; }
        [JsonProperty("player")]
        public DestinyPlayer Player { get; set; }
        [JsonProperty("characterId")]
        public Int64 CharacterId { get; set; }
        [JsonProperty("values")]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }
        [JsonProperty("extended")]
        public DestinyPostGameCarnageReportExtendedData Extended { get; set; }
    }
}
