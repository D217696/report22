using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Vendors
{
    public class DestinyVendorSaleItemComponent
    {
        [JsonProperty("saleStatus")]
        public Int32 SaleStatus { get; set; }
        [JsonProperty("requiredUnlocked")]
        public UInt32[] RequiredUnlocked { get; set; }
        [JsonProperty("unlockStatuses")]
        public DestinyUnlockStatus[] UnlockStatuses { get; set; }
        [JsonProperty("failureIndexes")]
        public Int32[] FailureIndexes { get; set; }
        [JsonProperty("augments")]
        public Int32 Augments { get; set; }
        [JsonProperty("vendorItemIndex")]
        public Int32 VendorItemIndex { get; set; }
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("overrideStyleItemHash")]
        public UInt32 OverrideStyleItemHash { get; set; }
        [JsonProperty("quantity")]
        public Int32 Quantity { get; set; }
        [JsonProperty("costs")]
        public DestinyItemQuantity[] Costs { get; set; }
        [JsonProperty("overrideNextRefreshDate")]
        public DateTime OverrideNextRefreshDate { get; set; }
    }
}
