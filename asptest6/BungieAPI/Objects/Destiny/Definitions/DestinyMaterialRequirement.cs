using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyMaterialRequirement
    {
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("deleteOnAction")]
        public bool DeleteOnAction { get; set; }
        [JsonProperty("count")]
        public Int32 Count { get; set; }
        [JsonProperty("omitFromRequirements")]
        public bool OmitFromRequirements { get; set; }
    }
}
