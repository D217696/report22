using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyVendorsResponse
    {
        [JsonProperty("vendorGroups")]
        public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }
        [JsonProperty("vendors")]
        public DictionaryComponentResponseOfuint32AndDestinyVendorComponent Vendors { get; set; }
        [JsonProperty("categories")]
        public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; set; }
        [JsonProperty("sales")]
        public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent Sales { get; set; }
        [JsonProperty("itemComponents")]
        public Dictionary<UInt32, DestinyItemComponentSetOfint32> ItemComponents { get; set; }
        [JsonProperty("currencyLookups")]
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }
    }
}
