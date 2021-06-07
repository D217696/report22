using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Content.Models
{
    public class TagMetadataDefinition
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("order")]
        public Int32 Order { get; set; }
        [JsonProperty("items")]
        public TagMetadataItem[] Items { get; set; }
        [JsonProperty("datatype")]
        public string Datatype { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }
    }
}
