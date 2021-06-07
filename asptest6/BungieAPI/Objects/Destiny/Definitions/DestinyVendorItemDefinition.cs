using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorItemDefinition
    {
        [JsonProperty("vendorItemIndex")]
        public Int32 VendorItemIndex { get; set; }
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("quantity")]
        public Int32 Quantity { get; set; }
        [JsonProperty("failureIndexes")]
        public Int32[] FailureIndexes { get; set; }
        [JsonProperty("currencies")]
        public DestinyVendorItemQuantity[] Currencies { get; set; }
        [JsonProperty("refundPolicy")]
        public Int32 RefundPolicy { get; set; }
        [JsonProperty("refundTimeLimit")]
        public Int32 RefundTimeLimit { get; set; }
        [JsonProperty("creationLevels")]
        public DestinyItemCreationEntryLevelDefinition[] CreationLevels { get; set; }
        [JsonProperty("displayCategoryIndex")]
        public Int32 DisplayCategoryIndex { get; set; }
        [JsonProperty("categoryIndex")]
        public Int32 CategoryIndex { get; set; }
        [JsonProperty("originalCategoryIndex")]
        public Int32 OriginalCategoryIndex { get; set; }
        [JsonProperty("minimumLevel")]
        public Int32 MinimumLevel { get; set; }
        [JsonProperty("maxmimumLevel")]
        public Int32 MaxmimumLevel { get; set; }
        [JsonProperty("action")]
        public DestinyVendorSaleItemActionBlockDefinition Action { get; set; }
        [JsonProperty("displayCategory")]
        public string DisplayCategory { get; set; }
        [JsonProperty("inventoryBucketHash")]
        public UInt32 InventoryBucketHash { get; set; }
        [JsonProperty("visibilityScope")]
        public Int32 VisibilityScope { get; set; }
        [JsonProperty("purchasableScope")]
        public Int32 PurchasableScope { get; set; }
        [JsonProperty("exclusivity")]
        public Int32 Exclusivity { get; set; }
        [JsonProperty("isOffer")]
        public bool IsOffer { get; set; }
        [JsonProperty("isCrm")]
        public bool IsCrm { get; set; }
        [JsonProperty("sortValue")]
        public Int32 SortValue { get; set; }
        [JsonProperty("expirationTooltip")]
        public string ExpirationTooltip { get; set; }
        [JsonProperty("redirectToSaleIndexes")]
        public Int32[] RedirectToSaleIndexes { get; set; }
        [JsonProperty("socketOverrides")]
        public DestinyVendorItemSocketOverride[] SocketOverrides { get; set; }
    }
}
