using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsPerCharacter
    {
        [JsonProperty("characterId")]
        public Int64 CharacterId { get; set; }
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
        [JsonProperty("results")]
        public Dictionary<string, DestinyHistoricalStatsByPeriod> Results { get; set; }
        [JsonProperty("merged")]
        public DestinyHistoricalStatsByPeriod Merged { get; set; }
    }
}
