using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Items
{
    public class DestinyDerivedItemDefinition
    {
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("itemName")]
        public string ItemName { get; set; }
        [JsonProperty("itemDetail")]
        public string ItemDetail { get; set; }
        [JsonProperty("itemDescription")]
        public string ItemDescription { get; set; }
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("vendorItemIndex")]
        public Int32 VendorItemIndex { get; set; }
    }
}
