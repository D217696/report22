using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemInstanceEnergy
    {
        [JsonProperty("energyTypeHash")]
        public UInt32 EnergyTypeHash { get; set; }
        [JsonProperty("energyType")]
        public Int32 EnegryType { get; set; }
        [JsonProperty("energyCapacity")]
        public Int32 EnegryCapacity { get; set; }
        [JsonProperty("energyUsed")]
        public Int32 EnergyUsed { get; set; }
        [JsonProperty("energyUnused")]
        public Int32 EnergyUnused { get; set; }
    }
}