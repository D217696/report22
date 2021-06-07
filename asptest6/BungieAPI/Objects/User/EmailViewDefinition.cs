using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.User
{
    public class EmailViewDefinition
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("viewSettings")]
        public EmailViewDefinitionSetting ViewSettings { get; set; }
    }
}
