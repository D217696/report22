using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyPostGameCarnageReportData
    {
        [JsonProperty("period")]
        public DateTime Period { get; set; }
        [JsonProperty("startingPhaseIndex")]
        public Int32 StartingPhaseIndex { get; set; }
        [JsonProperty("activityDetails")]
        public DestinyHistoricalStatsActivity ActivityDetails { get; set; }
        [JsonProperty("entries")]
        public DestinyPostGameCarnageReportEntry[] Entries { get; set; }
        [JsonProperty("teams")]
        public DestinyPostGameCarnageReportTeamEntry[] Teams { get; set; }
    }
}
