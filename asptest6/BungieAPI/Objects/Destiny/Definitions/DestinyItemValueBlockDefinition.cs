using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemValueBlockDefinition
    {
        [JsonProperty("itemValue")]
        public DestinyItemQuantity[] ItemValue { get; set; }
        [JsonProperty("valueDescription")]
        public string ValueDescription { get; set; }
    }
}
