using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions.Animations;
using NiobeLab.Core.Objects.Destiny.Definitions.Common;
using NiobeLab.Core.Objects.Destiny.Definitions.Items;
using NiobeLab.Core.Objects.Destiny.Misc;
using NiobeLab.Core.Objects.Links;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyInventoryItemDefinition
    {
        [JsonProperty("displayProperties")]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("tooltipNotifications")]
        public DestinyItemTooltipNotification[] TooltipNotifications { get; set; }
        [JsonProperty("collectibleHash")]
        public UInt32 CollectibleHash { get; set; }
        [JsonProperty("secondaryIcon")]
        public string SecondaryIcon { get; set; }
        [JsonProperty("secondaryOverlay")]
        public string SecondaryOverlay { get; set; }
        [JsonProperty("secondarySpecial")]
        public string SecondarySpecial { get; set; }
        [JsonProperty("backgroundColor")]
        public DestinyColor BackgroundColor { get; set; }
        [JsonProperty("screenshot")]
        public string Screenshot { get; set; }
        [JsonProperty("itemTypeDisplayName")]
        public string ItemTypeDisplayName { get; set; }
        [JsonProperty("uiItemDisplayStyle")]
        public string UiItemDisplayStyle { get; set; }
        [JsonProperty("itemTypeAndTierDisplayName")]
        public string ItemTypeAndTierDisplayName { get; set; }
        [JsonProperty("displaySource")]
        public string DisplaySource { get; set; }
        [JsonProperty("tooltipStyle")]
        public string TooltipStyle { get; set; }
        [JsonProperty("action")]
        public DestinyItemActionBlockDefinition Action { get; set; }
        [JsonProperty("inventory")]
        public DestinyItemInventoryBlockDefinition Inventory { get; set; }
        [JsonProperty("setData")]
        public DestinyItemSetBlockDefinition SetData { get; set; }
        [JsonProperty("stats")]
        public DestinyItemStatBlockDefinition Stats { get; set; }
        [JsonProperty("emblemObjectiveHash")]
        public UInt32 EmblemObjectiveHash { get; set; }
        [JsonProperty("equippingBlock")]
        public DestinyEquippingBlockDefinition EquippingBlock { get; set; }
        [JsonProperty("translationBlock")]
        public DestinyItemTranslationBlockDefinition TranslationBlock { get; set; }
        [JsonProperty("preview")]
        public DestinyItemPreviewBlockDefinition Preview { get; set; }
        [JsonProperty("quality")]
        public DestinyItemQualityBlockDefinition Quality { get; set; }
        [JsonProperty("value")]
        public DestinyItemValueBlockDefinition Value { get; set; }
        [JsonProperty("sourceData")]
        public DestinyItemSourceBlockDefinition SourceData { get; set; }
        [JsonProperty("objectives")]
        public DestinyItemObjectiveBlockDefinition Objectives { get; set; }
        [JsonProperty("plug")]
        public DestinyItemPlugDefinition Plug { get; set; }
        [JsonProperty("gearset")]
        public DestinyItemGearsetBlockDefinition Gearset { get; set; }
        [JsonProperty("sack")]
        public DestinyItemSackBlockDefinition Sack { get; set; }
        [JsonProperty("sockets")]
        public DestinyItemSocketBlockDefinition Sockets { get; set; }
        [JsonProperty("summary")]
        public DestinyItemSummaryBlockDefinition Summary { get; set; }
        [JsonProperty("talentGrid")]
        public DestinyItemTalentGridBlockDefinition TalentGrid { get; set; }
        [JsonProperty("investmentStats")]
        public DestinyItemInvestmentStatDefinition[] InvestmentStats { get; set; }
        [JsonProperty("perks")]
        public DestinyItemPerkEntryDefinition[] Perks { get; set; }
        [JsonProperty("loreHash")]
        public UInt32 LoreHash { get; set; }
        [JsonProperty("summaryItemHash")]
        public UInt32 SummaryItemHash { get; set; }
        [JsonProperty("animations")]
        public DestinyAnimationReference[] Animations { get; set; }
        [JsonProperty("allowActions")]
        public bool AllowActions { get; set; }
        [JsonProperty("links")]
        public HyperlinkReference[] Links { get; set; }
        [JsonProperty("doesPostmasterPullHaveSideEffects")]
        public bool DoesPostmasterPullHaveSideEffects { get; set; }
        [JsonProperty("nonTransferrable")]
        public bool NonTransferrable { get; set; }
        [JsonProperty("itemCategoryHashes")]
        public UInt32[] ItemCategoryHashes { get; set; }
        [JsonProperty("specialItemType")]
        public Int32 SpecialItemType { get; set; }
        [JsonProperty("itemType")]
        public Int32 ItemType { get; set; }
        [JsonProperty("itemSubType")]
        public Int32 ItemSubType { get; set; }
        [JsonProperty("classType")]
        public Int32 ClassType { get; set; }
        [JsonProperty("breakerType")]
        public Int32 BreakerType { get; set; }
        [JsonProperty("breakerTypeHash")]
        public UInt32 BreakerTypeHash { get; set; }
        [JsonProperty("equippable")]
        public bool Equippable { get; set; }
        [JsonProperty("damageTypeHashes")]
        public UInt32[] DamageTypeHashes { get; set; }
        [JsonProperty("damageTypes")]
        public Int32[] DamageTypes { get; set; }
        [JsonProperty("defaultDamageType")]
        public Int32 DefaultDamageType { get; set; }
        [JsonProperty("defaultDamageTypeHash")]
        public UInt32 DefaultDamageTypeHash { get; set; }
        [JsonProperty("seasonHash")]
        public UInt32 SeasonHash { get; set; }
        [JsonProperty("isWrapper")]
        public bool IsWrapper { get; set; }
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("index")]
        public Int32 Index { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }
    }
}
