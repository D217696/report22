using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Collectibles
{
    public class DestinyCollectibleComponent
    {
        [JsonProperty("state")]
        public Int32 State { get; set; }
    }
}
