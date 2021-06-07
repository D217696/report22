using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.PlugSets;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyPlugSetsComponent
    {
        [JsonProperty("data")]
        public DestinyPlugSetsComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
