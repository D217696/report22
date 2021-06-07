using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemQualityBlockDefinition
    {
        [JsonProperty("itemLevels")]
        public Int32[] ItemLevels { get; set; }
        [JsonProperty("qualityLevel")]
        public Int32 QualityLevel { get; set; }
        [JsonProperty("infusionCategoryHashes")]
        public UInt32[] InfusionCategoryHashes { get; set; }
        [JsonProperty("progressionLevelRequirementHash")]
        public UInt32 ProgressionLevelRequirementHash { get; set; }
    }
}
