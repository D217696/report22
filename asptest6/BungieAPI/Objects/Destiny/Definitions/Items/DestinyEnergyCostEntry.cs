using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Items
{
    public class DestinyEnergyCostEntry
    {
        [JsonProperty("energyCost")]
        public Int32 EnergyCost { get; set; }
        [JsonProperty("energyTypeHash")]
        public UInt32 EnergyTypeHash { get; set; }
        [JsonProperty("energyType")]
        public Int32 EnergyType { get; set; }
    }
}
