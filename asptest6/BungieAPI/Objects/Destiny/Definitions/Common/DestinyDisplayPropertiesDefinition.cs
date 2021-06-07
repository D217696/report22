using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Common
{
    public class DestinyDisplayPropertiesDefinition
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("highResIcon")]
        public string HighResIcon { get; set; }
        [JsonProperty("hasIcon")]
        public bool HasIcon { get; set; }
    }
}
