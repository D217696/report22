using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Items
{
    public class DestinyItemPlugDefinition
    {
        [JsonProperty("insertionRules")]
        public DestinyPlugRuleDefinition[] InsertionRules { get; set; }
        [JsonProperty("plugCategoryIdentifier")]
        public string PlugCategoryIdentifier { get; set; }
        [JsonProperty("plugCategoryHash")]
        public UInt32 PlugCategoryHash { get; set; }
        [JsonProperty("onActionRecreateSelf")]
        public bool OnActionRecreateSelf { get; set; }
        [JsonProperty("insertionMaterialRequirementHash")]
        public UInt32 InsertionMaterialRequirementHash { get; set; }
        [JsonProperty("previewItemOverrideHash")]
        public UInt32 PreviewItemOverrideHash { get; set; }
        [JsonProperty("enabledMaterialRequirementHash")]
        public UInt32 EnabledMaterialRequirementHash { get; set; }
        [JsonProperty("enabledRules")]
        public DestinyPlugRuleDefinition[] EnabledRules { get; set; }
        [JsonProperty("uiPlugLabel")]
        public string UiPlugLabel { get; set; }
        [JsonProperty("plugStyle")]
        public Int32 PlugStyle { get; set; }
        [JsonProperty("plugAvailability")]
        public Int32 PlugAvailability { get; set; }
        [JsonProperty("alternateUiPlugLabel")]
        public string AlternateUiPlugLabel { get; set; }
        [JsonProperty("alternatePlugStyle")]
        public Int32 AlternatePlugStyle { get; set; }
        [JsonProperty("isDummyPlug")]
        public bool IsDummyPlug { get; set; }
        [JsonProperty("parentItemOverride")]
        public DestinyParentItemOverride ParentItemOverride { get; set; }
        [JsonProperty("energyCapacity")]
        public DestinyEnergyCapacityEntry EnergyCapacity { get; set; }
        [JsonProperty("energyCost")]
        public DestinyEnergyCostEntry EnergyCost { get; set; }
    }
}
