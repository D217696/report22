using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Vendors
{
    public class DestinyVendorGroupComponent
    {
        [JsonProperty("groups")]
        public DestinyVendorGroup[] Groups { get; set; }
    }
}
