using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Vendors
{
    public class DestinyPublicVendorSaleItemComponent
    {
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
        public DateFormatHandling OverrideNextRefreshDate { get; set; }
    }
}
