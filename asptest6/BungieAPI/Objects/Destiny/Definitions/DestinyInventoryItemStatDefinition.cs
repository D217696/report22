using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyInventoryItemStatDefinition
    {
        [JsonProperty("statHash")]
        public UInt32 statHash { get; set; }
        [JsonProperty("value")]
        public Int32 Value { get; set; }
        [JsonProperty("minimum")]
        public Int32 Minimum { get; set; }
        [JsonProperty("maximum")]
        public Int32 Maximum { get; set; }
    }
}
