using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Vendors
{
    public class DestinyVendorReceipt
    {
        [JsonProperty("currencyPaid")]
        public DestinyItemQuantity[] CurrencyPaid { get; set; }
        [JsonProperty("itemReceived")]
        public DestinyItemQuantity ItemRecieved { get; set; }
        [JsonProperty("licenseUnlockHash")]
        public UInt32 LicenseUnlockHash { get; set; }
        [JsonProperty("purchasedByCharacterId")]
        public Int64 PurchasedByCharacterId { get; set; }
        [JsonProperty("refundPolicy")]
        public Int32 RefundPolicy { get; set; }
        [JsonProperty("sequenceNumber")]
        public Int32 SequenceNumber { get; set; }
        [JsonProperty("timeToExpiration")]
        public Int64 TimeToExpiration { get; set; }
        [JsonProperty("expiresOn")]
        public DateTime ExpiresOn { get; set; }
    }
}
