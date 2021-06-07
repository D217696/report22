using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemInstanceComponent
    {
        [JsonProperty("damageType")]
        public Int32 DamageType { get; set; }
        [JsonProperty("damageTypeHash")]
        public UInt32 DamageTypeHash { get; set; }
        [JsonProperty("primaryStat")]
        public DestinyStat PrimaryStat { get; set; }
        [JsonProperty("itemLevel")]
        public Int32 ItemLevel { get; set; }
        [JsonProperty("quality")]
        public Int32 Quality { get; set; }
        [JsonProperty("isEquipped")]
        public bool IsEquipped { get; set; }
        [JsonProperty("canEquip")]
        public bool CanEquip { get; set; }
        [JsonProperty("equipRequiredLevel")]
        public Int32 EquipRequiredLevel { get; set; }
        [JsonProperty("unlockHashesRequiredToEquip")]
        public UInt32[] UnlockHashesRequiredToEquip { get; set; }
        [JsonProperty("cannotEquipReason")]
        public UInt32 CannotEquipReason { get; set; }
        [JsonProperty("breakerType")]
        public Int32 BreakerType { get; set; }
        [JsonProperty("breakerTypeHash")]
        public UInt32 BreakerTypeHash { get; set; }
        [JsonProperty("energy")]
        public DestinyItemInstanceEnergy Energy { get; set; }
    }
}