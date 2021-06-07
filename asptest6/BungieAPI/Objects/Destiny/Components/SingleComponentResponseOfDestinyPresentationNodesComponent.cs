using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Presentation;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyPresentationNodesComponent
    {
        [JsonProperty("data")]
        public DestinyPresentationNodesComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
