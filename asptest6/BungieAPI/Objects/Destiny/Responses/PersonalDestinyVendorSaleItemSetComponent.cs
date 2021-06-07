using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Vendors;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class PersonalDestinyVendorSaleItemSetComponent
    {
        [JsonProperty("saleItems")]
        public Dictionary<Int32, DestinyVendorSaleItemComponent> SaleItems { get; set; }
    }
}
