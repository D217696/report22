using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyPostGameCarnageReportTeamEntry
    {
        [JsonProperty("teamId")]
        public Int32 TeamId { get; set; }
        [JsonProperty("standing")]
        public DestinyHistoricalStatsValue Standing { get; set; }
        [JsonProperty("score")]
        public DestinyHistoricalStatsValue Score { get; set; }
        [JsonProperty("teamName")]
        public string TeamName { get; set; }
    }
}
