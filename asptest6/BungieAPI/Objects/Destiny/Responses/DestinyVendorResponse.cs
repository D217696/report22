using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyVendorResponse
    {
        [JsonProperty("vendor")]
        public SingleComponentResponseOfDestinyVendorComponent Vendor { get; set; }
        [JsonProperty("categories")]
        public SingleComponentResponseOfDestinyVendorCategoriesComponent Categories { get; set; }
        [JsonProperty("sales")]
        public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent Sales { get; set; }
        [JsonProperty("itemComponents")]
        public DestinyItemComponentSetOfint32 ItemComponents { get; set; }
        [JsonProperty("currencyLookups")]
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }
    }
}
