using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Links
{
    public class HyperlinkReference
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
