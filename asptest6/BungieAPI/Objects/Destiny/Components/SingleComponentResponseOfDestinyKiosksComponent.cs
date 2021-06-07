using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Kiosks;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyKiosksComponent
    {
        [JsonProperty("data")]
        public DestinyKiosksComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
