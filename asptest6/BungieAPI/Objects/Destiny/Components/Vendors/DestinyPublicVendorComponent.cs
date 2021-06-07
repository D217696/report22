using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Vendors
{
    public class DestinyPublicVendorComponent
    {
        [JsonProperty("vendorHash")]
        public UInt32 VendorHash { get; set; }
        [JsonProperty("nextRefreshDate")]
        public DateTime NextRefreshDate { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
