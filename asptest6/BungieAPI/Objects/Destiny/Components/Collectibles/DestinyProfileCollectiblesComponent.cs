using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Collectibles
{
    public class DestinyProfileCollectiblesComponent
    {
        [JsonProperty("recentCollectibleHashes")]
        public UInt32[] RecentCollectibleHashes { get; set; }
        [JsonProperty("newnessFlaggedCollectibleHashes")]
        public UInt32[] NewnessFlaggedCollectibleHashes { get; set; }
        [JsonProperty("collectibles")]
        public Dictionary<UInt32, DestinyCollectibleComponent> Collectibles { get; set; }
    }
}
