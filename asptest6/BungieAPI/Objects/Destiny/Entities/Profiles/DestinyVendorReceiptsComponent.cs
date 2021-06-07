using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Vendors;

namespace NiobeLab.Core.Objects.Destiny.Entities.Profiles
{
    public class DestinyVendorReceiptsComponent
    {
        [JsonProperty("receipts")]
        public DestinyVendorReceipt[] Receipts { get; set; }
    }
}
