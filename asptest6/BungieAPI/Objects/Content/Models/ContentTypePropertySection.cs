using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Content.Models
{
    public class ContentTypePropertySection
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("readableName")]
        public string ReadableName { get; set; }
        [JsonProperty("collapsed")]
        public bool Collapsed { get; set; }
    }
}
