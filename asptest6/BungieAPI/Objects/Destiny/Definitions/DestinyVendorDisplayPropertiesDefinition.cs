using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorDisplayPropertiesDefinition
    {
        [JsonProperty("largeIcon")]
        public string LargeIcon { get; set; }
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
        [JsonProperty("originalIcon")]
        public string OriginalIcon { get; set; }
        [JsonProperty("requirementsDisplay")]
        public DestinyVendorRequirementDisplayEntryDefinition[] RequirementsDisplay { get; set; }
        [JsonProperty("smallTransparentIcon")]
        public string SmallTransparentIcon { get; set; }
        [JsonProperty("mapIcon")]
        public string MapIcon { get; set; }
        [JsonProperty("largeTransparentIcon")]
        public string LargeTransparentIcon { get; set; }
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
