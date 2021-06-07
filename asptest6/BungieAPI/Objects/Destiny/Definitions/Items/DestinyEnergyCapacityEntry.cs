using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Items
{
    public class DestinyEnergyCapacityEntry
    {
        [JsonProperty("capacityValue")]
        public Int32 CapacityValue { get; set; }
        [JsonProperty("energyTypeHash")]
        public UInt32 EnergyTypeHash { get; set; }
        [JsonProperty("energyType")]
        public Int32 EnergyType { get; set; }
    }
}
