using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Entities.Vendors
{
    public class DestinyVendorCategoriesComponent
    {
        [JsonProperty("categories")]
        public DestinyVendorCategory[] Categories { get; set; }
    }
}
