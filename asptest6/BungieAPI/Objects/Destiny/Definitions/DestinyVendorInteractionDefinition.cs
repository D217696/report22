using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions.Common;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorInteractionDefinition
    {
        [JsonProperty("interactionIndex")]
        public Int32 InteractionIndex { get; set; }
        [JsonProperty("replies")]
        public DestinyVendorInteractionReplyDefinition[] Replies { get; set; }
        [JsonProperty("vendorCategoryIndex")]
        public Int32 VendorCategoryIndex { get; set; }
        [JsonProperty("questlineItemHash")]
        public Int32 QuestlineItemHash { get; set; }
        [JsonProperty("sackInteractionList")]
        public DestinyVendorInteractionSackEntryDefinition[] SackInteractionList { get; set; }
        [JsonProperty("uiInteractionType")]
        public UInt32 UiInteractionType { get; set; }
        [JsonProperty("interactionType")]
        public Int32 InteractionType { get; set; }
        [JsonProperty("rewardBlockLabel")]
        public string RewardBlockLabel { get; set; }
        [JsonProperty("rewardVendorCategoryIndex")]
        public Int32 RewardVendorCategoryIndex { get; set; }
        [JsonProperty("flavorLineOne")]
        public string FlavorLineOne { get; set; }
        [JsonProperty("flavorLineTwo")]
        public string FlavorLineTwo { get; set; }
        [JsonProperty("headerDisplayProperties")]
        public DestinyDisplayPropertiesDefinition HeaderDisplayProperties { get; set; }
        [JsonProperty("instructions")]
        public string Instructions { get; set; }
    }
}
