using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Items
{
    public class DestinyPlugRuleDefinition
    {
        [JsonProperty("failureMessage")]
        public string FailureMessage { get; set; }
    }
}
