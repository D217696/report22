using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsDefinition
    {
        [JsonProperty("statId")]
        public string StatId { get; set; }
        [JsonProperty("group")]
        public Int32 Group { get; set; }
        [JsonProperty("periodTypes")]
        public Int32[] PeriodTypes { get; set; }
        [JsonProperty("modes")]
        public Int32[] Modes { get; set; }
        [JsonProperty("category")]
        public Int32 Category { get; set; }
        [JsonProperty("statName")]
        public string StatName { get; set; }
        [JsonProperty("statNameAbbr")]
        public string StatNameAbbr { get; set; }
        [JsonProperty("statDescription")]
        public string StatDescription { get; set; }
        [JsonProperty("unitType")]
        public Int32 UnitType { get; set; }
        [JsonProperty("iconImage")]
        public string IconImage { get; set; }
        [JsonProperty("mergeMethod")]
        public Int32 MergeMethod { get; set; }
        [JsonProperty("unitLabel")]
        public string UnitLabel { get; set; }
        [JsonProperty("weight")]
        public Int32 Weight { get; set; }
        [JsonProperty("medalTierHash")]
        public UInt32 MedalTierHash { get; set; }
    }
}
