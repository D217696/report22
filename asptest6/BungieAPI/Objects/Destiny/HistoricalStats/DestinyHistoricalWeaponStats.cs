using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalWeaponStats
    {
        [JsonProperty("referenceId")]
        public UInt32 ReferenceId { get; set; }
        [JsonProperty("values")]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }
    }
}
