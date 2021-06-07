using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Applications
{
    public class Series
    {
        [JsonProperty("datapoints")]
        public Datapoint[] Datapoints { get; set; }
        [JsonProperty("target")]
        public string Target { get; set; }
    }
}
