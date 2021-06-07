using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Vendors
{
    public class DestinyVendorGroup
    {
        [JsonProperty("vendorGroupHash")]
        public UInt32 VendorGroupHash { get; set; }
        [JsonProperty("vendorHashes")]
        public UInt32[] VendorHashes { get; set; }
    }
}