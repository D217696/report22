using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Common.Models
{
    public class CoreSetting
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
        [JsonProperty("childSettings")]
        public CoreSetting[] ChildSettings { get; set; }
    }
}
