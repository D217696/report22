using Newtonsoft.Json;
using NiobeLab.Core.Objects.Dates;
using NiobeLab.Core.Objects.Destiny.Definitions.Vendors;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorDefinition
    {
        [JsonProperty("displayProperties")]
        public DestinyVendorDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("buyString")]
        public string BuyString { get; set; }
        [JsonProperty("sellString")]
        public string SellString { get; set; }
        [JsonProperty("displayItemHash")]
        public UInt32 DisplayItemHash { get; set; }
        [JsonProperty("inhibitBuying")]
        public bool InhibitBuying { get; set; }
        [JsonProperty("inhibitSelling")]
        public bool InhibitSelling { get; set; }
        [JsonProperty("factionHash")]
        public UInt32 FactionHash { get; set; }
        [JsonProperty("resetIntervalMinutes")]
        public Int32 ResetInteralMinutes { get; set; }
        [JsonProperty("resetOffsetMinutes")]
        public Int32 ResetOffsetMinutes { get; set; }
        [JsonProperty("failureStrings")]
        public string[] FailureStrings { get; set; }
        [JsonProperty("unlockRanges")]
        public DateRange[] UnlockRanges { get; set; }
        [JsonProperty("vendorIdentifier")]
        public string VendorIdentifier { get; set; }
        [JsonProperty("vendorPortrait")]
        public string VendorPortrait { get; set; }
        [JsonProperty("vendorBanner")]
        public string VendorBanner { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        [JsonProperty("vendorSubcategoryIdentifier")]
        public string VendorSubcategoryIdentifier { get; set; }
        [JsonProperty("consolidateCategories")]
        public bool ConsolidateCategories { get; set; }
        [JsonProperty("actions")]
        public DestinyVendorActionDefinition[] Actions { get; set; }
        [JsonProperty("categories")]
        public DestinyVendorCategoryEntryDefinition[] Categories { get; set; }
        [JsonProperty("originalCategories")]
        public DestinyVendorCategoryEntryDefinition[] OriginalCategories { get; set; }
        [JsonProperty("displayCategories")]
        public DestinyDisplayCategoryDefinition[] DisplayCategories { get; set; }
        [JsonProperty("interactions")]
        public DestinyVendorInteractionDefinition[] Interactions { get; set; }
        [JsonProperty("inventoryFlyouts")]
        public DestinyVendorInventoryFlyoutDefinition[] InventoryFlyouts { get; set; }
        [JsonProperty("itemList")]
        public DestinyVendorItemDefinition[] ItemList { get; set; }
        [JsonProperty("services")]
        public DestinyVendorServiceDefinition[] Services { get; set; }
        [JsonProperty("acceptedItems")]
        public DestinyVendorAcceptedItemDefinition[] AcceptedItems { get; set; }
        [JsonProperty("returnWithVendorRequest")]
        public bool ReturnWithVendorRequest { get; set; }
        [JsonProperty("locations")]
        public DestinyVendorLocationDefinition[] Locations { get; set; }
        [JsonProperty("groups")]
        public DestinyVendorGroupReference[] Groups { get; set; }
        [JsonProperty("ignoreSaleItemHashes")]
        public UInt32[] IgnoreSaleItemHashes { get; set; }
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("index")]
        public Int32 Index { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }
    }
}
