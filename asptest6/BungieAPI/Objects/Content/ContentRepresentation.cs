using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Content
{
    public class ContentRepresentation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("validationString")]
        public string ValidationString { get; set; }
    }
}
