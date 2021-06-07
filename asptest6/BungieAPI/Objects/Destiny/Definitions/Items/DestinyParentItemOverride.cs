using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Items
{
    public class DestinyParentItemOverride
    {
        [JsonProperty("additionalEquipRequirementsDisplayStrings")]
        public string[] AdditionalEquipRequirementsDisplayStrings { get; set; }
        [JsonProperty("pipIcon")]
        public string PipIcon { get; set; }
    }
}
