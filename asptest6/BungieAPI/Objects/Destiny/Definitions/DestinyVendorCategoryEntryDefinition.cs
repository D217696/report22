using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorCategoryEntryDefinition
    {
        [JsonProperty("categoryIndex")]
        public Int32 CategoryIndex { get; set; }
        [JsonProperty("sortValue")]
        public Int32 SortValue { get; set; }
        [JsonProperty("categoryHash")]
        public UInt32 CategoryHash { get; set; }
        [JsonProperty("quantityAvailable")]
        public Int32 QuantityAvailable { get; set; }
        [JsonProperty("showUnavailableItems")]
        public bool ShowUnavailableItems { get; set; }
        [JsonProperty("hideIfNoCurrency")]
        public bool HideIfNoCurrency { get; set; }
        [JsonProperty("hideFromRegularPurchase")]
        public bool HideFromRegularPurchase { get; set; }
        [JsonProperty("buyStringOverride")]
        public string BuyStringOverride { get; set; }
        [JsonProperty("disabledDescription")]
        public string DisabledDescription { get; set; }
        [JsonProperty("displayTitle")]
        public string displayTitle { get; set; }
        [JsonProperty("overlay")]
        public DestinyVendorCategoryOverlayDefinition Overlay { get; set; }
        [JsonProperty("vendorItemIndexes")]
        public Int32[] VendorItemIndexes { get; set; }
        [JsonProperty("isPreview")]
        public bool IsPreview { get; set; }
        [JsonProperty("isDisplayOnly")]
        public bool IsDisplayOnly { get; set; }
        [JsonProperty("resetIntervalMinutesOverride")]
        public Int32 ResetIntervalMinutesOverride { get; set; }
        [JsonProperty("resetOffsetMinutesOverride")]
        public Int32 ResetOffsetMinutesOverride { get; set; }
    }
}
