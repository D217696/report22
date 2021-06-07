using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyItemObjectivesComponent
    {
        [JsonProperty("data")]
        public DestinyItemObjectivesComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
