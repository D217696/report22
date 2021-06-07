using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemPerkEntryDefinition
    {
        [JsonProperty("requirementDisplayString")]
        public string RequirementDisplayString { get; set; }
        [JsonProperty("perkHash")]
        public UInt32 PerkHash { get; set; }
        [JsonProperty("perkVisibility")]
        public Int32 PerkVisibility { get; set; }
    }
}
