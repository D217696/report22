using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Artifacts
{
    public class DestinyArtifactCharacterScoped
    {
        [JsonProperty("artifactHash")]
        public UInt32 ArtifactHash { get; set; }
        [JsonProperty("pointsUsed")]
        public Int32 PointsUsed { get; set; }
        [JsonProperty("resetCount")]
        public Int32 ResetCount { get; set; }
        [JsonProperty("tiers")]
        public DestinyArtifactTier[] Tiers { get; set; }
    }
}
