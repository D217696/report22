using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyLeaderboard
    {
        [JsonProperty("statId")]
        public string StatId { get; set; }
        [JsonProperty("entries")]
        public DestinyLeaderboardEntry[] Entries { get; set; }
    }
}
