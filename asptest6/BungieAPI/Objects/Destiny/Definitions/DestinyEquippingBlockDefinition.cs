using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyEquippingBlockDefinition
    {
        [JsonProperty("gearsetItemHash")]
        public UInt32 GeatetItemHash { get; set; }
        [JsonProperty("uniqueLabel")]
        public string UniqueLabel { get; set; }
        [JsonProperty("uniqueLabelHash")]
        public UInt32 UniqueLabelHash { get; set; }
        [JsonProperty("equipmentSlotTypeHash")]
        public UInt32 EquipmentSlotTypeHash { get; set; }
        [JsonProperty("attributes")]
        public Int32 Attributes { get; set; }
        [JsonProperty("ammoType")]
        public Int32 AmmoType { get; set; }
        [JsonProperty("displayStrings")]
        public string[] DisplayStrings { get; set; }
    }
}
