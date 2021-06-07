using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Content.Models
{
    public class ContentPreview
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("itemInSet")]
        public bool ItemInSet { get; set; }
        [JsonProperty("setTag")]
        public string SetTag { get; set; }
        [JsonProperty("setNesting")]
        public Int32 SetNesting { get; set; }
        [JsonProperty("useSetId")]
        public Int32 UseSetId { get; set; }
    }
}
