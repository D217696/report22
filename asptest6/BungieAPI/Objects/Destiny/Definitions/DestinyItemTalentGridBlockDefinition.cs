using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemTalentGridBlockDefinition
    {
        [JsonProperty("talentGridHash")]
        public UInt32 TalentGridHash { get; set; }
        [JsonProperty("itemDetailString")]
        public string ItemDetailString { get; set; }
        [JsonProperty("buildName")]
        public string BuildName { get; set; }
        [JsonProperty("hudDamageType")]
        public Int32 HudDamageType { get; set; }
        [JsonProperty("hudIcon")]
        public string HudIcon { get; set; }
    }
}
