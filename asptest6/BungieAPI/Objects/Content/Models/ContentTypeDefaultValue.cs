using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Content.Models
{
    public class ContentTypeDefaultValue
    {
        [JsonProperty("whenClause")]
        public string WhenClause { get; set; }
        [JsonProperty("whenValue")]
        public string WhenValue { get; set; }
        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }
    }
}
