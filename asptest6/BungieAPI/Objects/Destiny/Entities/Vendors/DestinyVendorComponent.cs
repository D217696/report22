using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Vendors
{
    public class DestinyVendorComponent
    {
        [JsonProperty("canPurchase")]
        public bool CanPurchase { get; set; }
        [JsonProperty("progression")]
        public DestinyProgression Progression { get; set; }
        [JsonProperty("vendorLocationIndex")]
        public Int32 VendorLocationIndex { get; set; }
        [JsonProperty("seasonalRank")]
        public Int32 SeasonalRank { get; set; }
        [JsonProperty("vendorHash")]
        public UInt32 VendorHash { get; set; }
        [JsonProperty("nextRefreshDate")]
        public DateTime NextRefreshDate { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
