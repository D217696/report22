using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyPublicVendorsResponse
    {
        [JsonProperty("vendorGroups")]
        public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }
        [JsonProperty("vendors")]
        public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent Vendors { get; set; }
        [JsonProperty("categories")]
        public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; set; }
        [JsonProperty("sales")]
        public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent Sales { get; set; }
    }
}
