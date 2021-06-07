using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions.Common;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyEntitySearchResultItem
    {
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("entityType")]
        public string EntityType { get; set; }
        [JsonProperty("displayProperties")]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("weight")]
        public double Weight { get; set; }
    }
}
