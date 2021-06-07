using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Sources
{
    public class DestinyItemSourceDefinition
    {
        [JsonProperty("level")]
        public Int32 Level { get; set; }
        [JsonProperty("minQuality")]
        public Int32 MinQuality { get; set; }
        [JsonProperty("maxQuality")]
        public Int32 MaxQuality { get; set; }
        [JsonProperty("minLevelRequired")]
        public Int32 MinLevelRequired { get; set; }
        [JsonProperty("maxLevelRequired")]
        public Int32 MaxLevelRequired { get; set; }
        [JsonProperty("computedStats")]
        public Dictionary<UInt32, DestinyInventoryItemStatDefinition> ComputedStats { get; set; }
        [JsonProperty("sourcesHashes")]
        public UInt32[] SourceHashes { get; set; }
    }
}
