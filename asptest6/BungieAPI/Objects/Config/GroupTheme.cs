using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Config
{
    public class GroupTheme
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("folder")]
        public string Folder { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
