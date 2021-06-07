using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsAccountResult
    {
        [JsonProperty("mergedDeletedCharacters")]
        public DestinyHistoricalStatsWithMerged MergedDeletedCharacters { get; set; }
        [JsonProperty("mergedAllCharacters")]
        public DestinyHistoricalStatsWithMerged MergedAllCharacters { get; set; }
        [JsonProperty("characters")]
        public DestinyHistoricalStatsPerCharacter[] Characters { get; set; }
    }
}
