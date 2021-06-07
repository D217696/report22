using Newtonsoft.Json;
using NiobeLab.Core.Objects.Ignores;

namespace NiobeLab.Core.Objects.Tags.Models.Contracts
{
    public class TagResponse
    {
        [JsonProperty("tagText")]
        public string TagText { get; set; }
        [JsonProperty("ignoreStatus")]
        public IgnoreResponse IgnoreStatus { get; set; }
    }
}
