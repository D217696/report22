using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityLoadoutRequirement
    {
        [JsonProperty("equipmentSlotHash")]
        public UInt32 EquipmentSlotHash { get; set; }
        [JsonProperty("allowedEquippedItemHashes")]
        public UInt32[] AllowedEquippedItemHashes { get; set; }
        [JsonProperty("allowedWeaponSubTypes")]
        public Int32[] AllowedWeaponSubTypes { get; set; }
    }
}
