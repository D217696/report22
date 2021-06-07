using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorInventoryFlyoutBucketDefinition
    {
        [JsonProperty("collapsible")]
        public bool Collapsible { get; set; }
        [JsonProperty("inventoryBucketHash")]
        public UInt32 InventoryBucketHash { get; set; }
        [JsonProperty("sortItemsBy")]
        public Int32 SortItemsBy { get; set; }
    }
}
