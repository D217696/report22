using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Profiles;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyProfileProgressionComponent
    {
        [JsonProperty("data")]
        public DestinyProfileProgressionComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
