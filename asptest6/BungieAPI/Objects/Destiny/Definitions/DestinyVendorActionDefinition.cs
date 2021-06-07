using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorActionDefinition
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("executeSeconds")]
        public Int32 ExecuteSeconds { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("verb")]
        public string Verg { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
        [JsonProperty("actionId")]
        public string ActionId { get; set; }
        [JsonProperty("actionHash")]
        public UInt32 ActionHash { get; set; }
        [JsonProperty("autoPerformAction")]
        public bool AutoPerformAction { get; set; }
    }
}
