using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Artifacts
{
    public class DestinyArtifactProfileScoped
    {
        [JsonProperty("artifactHash")]
        public UInt32 ArtifactHash { get; set; }
        [JsonProperty("pointProgression")]
        public DestinyProgression PointProgression { get; set; }
        [JsonProperty("pointsAcquired")]
        public Int32 PointsAcquired { get; set; }
        [JsonProperty("powerBonusProgression")]
        public DestinyProgression PowerBonusProgression { get; set; }
        [JsonProperty("powerBonus")]
        public Int32 PowerBonus { get; set; }
    }
}
