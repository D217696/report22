using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Collectibles;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyCollectiblesComponent
    {
        [JsonProperty("data")]
        public DestinyCollectiblesComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
