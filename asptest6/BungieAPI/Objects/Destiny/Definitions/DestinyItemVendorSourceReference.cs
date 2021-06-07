using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemVendorSourceReference
    {
        [JsonProperty("vendorHash")]
        public UInt32 VendorHash { get; set; }
        [JsonProperty("vendorItemIndexes")]
        public Int32[] VendorItemIndexes { get; set; }
    }
}
