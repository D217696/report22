using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Advanced
{
    public class AwaInitializeResponse
    {
        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }
        [JsonProperty("sentToSelf")]
        public bool SentToSelf { get; set; }
    }
}
