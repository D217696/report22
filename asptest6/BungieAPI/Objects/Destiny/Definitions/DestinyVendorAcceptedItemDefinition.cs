using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorAcceptedItemDefinition
    {
        [JsonProperty("acceptedInventoryBucketHash")]
        public UInt32 AcceptedInventoryBucketHash { get; set; }
        [JsonProperty("destinationInventoryBucketHash")]
        public UInt32 DestinationInventoryBucketHash { get; set; }
    }
}
