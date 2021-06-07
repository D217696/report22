using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyActivityHistoryResults
    {
        [JsonProperty("activities")]
        public DestinyHistoricalStatsPeriodGroup[] Activities { get; set; }
    }
}
