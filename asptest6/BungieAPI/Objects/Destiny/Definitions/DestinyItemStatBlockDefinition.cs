using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemStatBlockDefinition
    {
        [JsonProperty("disablePrimaryStatDisplay")]
        public bool DisablePrimaryStatDisplay { get; set; }
        [JsonProperty("statGroupHash")]
        public UInt32 StatGroupHash { get; set; }
        [JsonProperty("stats")]
        public Dictionary<UInt32, DestinyInventoryItemStatDefinition> Stats { get; set; }
        [JsonProperty("hasDisplayableStats")]
        public bool HasDisplayableStats { get; set; }
        [JsonProperty("primaryBaseStatHash")]
        public UInt32 PrimaryBaseStatHash { get; set; }
    }
}
