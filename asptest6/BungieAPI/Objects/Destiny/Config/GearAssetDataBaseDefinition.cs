using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Config
{
    public class GearAssetDataBaseDefinition
    {
        [JsonProperty("version")]
        public Int32 Version { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
