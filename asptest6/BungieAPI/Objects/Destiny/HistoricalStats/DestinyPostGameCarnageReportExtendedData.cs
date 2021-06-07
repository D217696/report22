using Newtonsoft.Json;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyPostGameCarnageReportExtendedData
    {
        [JsonProperty("weapons")]
        public DestinyHistoricalWeaponStats[] Weapons { get; set; }
        [JsonProperty("values")]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }
    }
}
