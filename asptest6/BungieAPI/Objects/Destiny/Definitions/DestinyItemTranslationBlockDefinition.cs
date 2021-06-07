using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemTranslationBlockDefinition
    {
        [JsonProperty("weaponPatternIdentifier")]
        public string WeaponPatternIdentifier { get; set; }
        [JsonProperty("weaponPatternHash")]
        public UInt32 WeaponPatternHash { get; set; }
        [JsonProperty("defaultDyes")]
        public DyeReference[] DefaultDyes { get; set; }
        [JsonProperty("lockedDyes")]
        public DyeReference[] LockedDyes { get; set; }
        [JsonProperty("customDyes")]
        public DyeReference[] CustomDyes { get; set; }
        [JsonProperty("arrangements")]
        public DestinyGearArtArrangementReference[] Arrangements { get; set; }
        [JsonProperty("hasGeometry")]
        public bool HasGeometry { get; set; }
    }
}
