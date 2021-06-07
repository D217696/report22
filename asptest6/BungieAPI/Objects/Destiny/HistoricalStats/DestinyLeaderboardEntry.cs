using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyLeaderboardEntry
    {
        [JsonProperty("rank")]
        public Int32 Rank { get; set; }
        [JsonProperty("player")]
        public DestinyPlayer Player { get; set; }
        [JsonProperty("characterId")]
        public Int64 CharacterId { get; set; }
        [JsonProperty("value")]
        public DestinyHistoricalStatsValue Value { get; set; }
    }
}
