using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions.Common;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorInventoryFlyoutDefinition
    {
        [JsonProperty("lockedDescription")]
        public string LockedDescription { get; set; }
        [JsonProperty("displayProperties")]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("buckets")]
        public DestinyVendorInventoryFlyoutBucketDefinition[] Buckets { get; set; }
        [JsonProperty("flyoutId")]
        public UInt32 FlyoutId { get; set; }
        [JsonProperty("suppressNewness")]
        public bool SuppressNewness { get; set; }
        [JsonProperty("equipmentSlotHash")]
        public UInt32 EquipmentSlotHash { get; set; }
    }
}
