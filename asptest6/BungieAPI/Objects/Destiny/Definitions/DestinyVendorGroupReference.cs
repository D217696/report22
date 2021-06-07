using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorGroupReference
    {
        [JsonProperty("vendorGroupHash")]
        public UInt32 VendorGroupHash { get; set; }
    }
}
