using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSocketEntryDefinition
    {
        [JsonProperty("socketTypeHash")]
        public UInt32 SocketTypeHash { get; set; }
        [JsonProperty("singleInitialItemHash")]
        public UInt32 SingleInitialItemHash { get; set; }
        [JsonProperty("reusablePlugItems")]
        public DestinyItemSocketEntryPlugItemDefinition[] ReusablePlugItems { get; set; }
        [JsonProperty("preventInitializationOnVendorPurchase")]
        public bool PreventInitializationOnVendorPurchase { get; set; }
        [JsonProperty("hidePerksInItemTooltip")]
        public bool HidePerksInItemTooltip { get; set; }
        [JsonProperty("plugSources")]
        public Int32 PlugSources { get; set; }
        [JsonProperty("reusablePlugSetHash")]
        public UInt32 ReusablePlugSetHash { get; set; }
        [JsonProperty("randomizedPlugSetHash")]
        public UInt32 RandomizedPlugSetHash { get; set; }
        [JsonProperty("defaultVisible")]
        public bool DefaultVisible { get; set; }
    }
}
