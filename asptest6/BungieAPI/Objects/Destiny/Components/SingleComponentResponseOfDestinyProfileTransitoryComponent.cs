using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Profiles;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyProfileTransitoryComponent
    {
        [JsonProperty("data")]
        public DestinyProfileTransitoryComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
