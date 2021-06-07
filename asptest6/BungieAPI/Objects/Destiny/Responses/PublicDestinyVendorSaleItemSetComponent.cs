using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Vendors;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class PublicDestinyVendorSaleItemSetComponent
    {
        [JsonProperty("saleItems")]
        public Dictionary<Int32, DestinyPublicVendorSaleItemComponent> SaleItems { get; set; }
    }
}
