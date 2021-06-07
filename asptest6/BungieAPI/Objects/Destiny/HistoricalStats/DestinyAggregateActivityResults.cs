using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyAggregateActivityResults
    {
        [JsonProperty("activities")]
        public DestinyAggregateActivityStats[] Activities { get; set; }
    }
}
