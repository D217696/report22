using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Perks
{
    public class DestinyPerkReference
    {
        [JsonProperty("perkHash")]
        public UInt32 PerkHash { get; set; }
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}
