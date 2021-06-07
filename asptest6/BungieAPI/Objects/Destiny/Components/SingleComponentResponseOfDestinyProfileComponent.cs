using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Profiles;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyProfileComponent
    {
        [JsonProperty("data")]
        public DestinyProfileComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
