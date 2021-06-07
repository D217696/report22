using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Collectibles
{
    public class DestinyCollectiblesComponent
    {
        [JsonProperty("collectibles")]
        public Dictionary<UInt32, DestinyCollectibleComponent> Collectibles { get; set; }
    }
}
