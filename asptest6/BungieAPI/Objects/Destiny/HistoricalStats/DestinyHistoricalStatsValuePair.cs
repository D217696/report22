using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsValuePair
    {
        [JsonProperty("value")]
        public double Value { get; set; }
        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}
