using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Collectibles;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyProfileCollectiblesComponent
    {
        [JsonProperty("data")]
        public DestinyProfileCollectiblesComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
