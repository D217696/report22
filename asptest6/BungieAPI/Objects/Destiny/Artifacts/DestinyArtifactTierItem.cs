using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Artifacts
{
    public class DestinyArtifactTierItem
    {
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }
}
