using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Characters;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyCharacterProgressionComponent
    {
        [JsonProperty("data")]
        public DestinyCharacterProgressionComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
