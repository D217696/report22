using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Characters;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyCharacterRenderComponent
    {
        [JsonProperty("data")]
        public DestinyCharacterRenderComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
