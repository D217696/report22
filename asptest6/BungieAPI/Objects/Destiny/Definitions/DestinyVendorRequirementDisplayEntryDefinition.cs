using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorRequirementDisplayEntryDefinition
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
