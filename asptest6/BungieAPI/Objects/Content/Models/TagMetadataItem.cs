using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Content.Models
{
    public class TagMetadataItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("tagText")]
        public string TagText { get; set; }
        [JsonProperty("groups")]
        public string[] Groups { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
