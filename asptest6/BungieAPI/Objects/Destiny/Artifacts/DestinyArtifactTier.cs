using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Artifacts
{
    public class DestinyArtifactTier
    {
        [JsonProperty("tierHash")]
        public UInt32 TierHash { get; set; }
        [JsonProperty("isUnlocked")]
        public bool IsUnlocked { get; set; }
        [JsonProperty("pointsToUnlock")]
        public Int32 PointsToUnlock { get; set; }
        [JsonProperty("items")]
        public DestinyArtifactTierItem[] Items { get; set; }
    }
}
