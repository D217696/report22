using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Presentation;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyPresentationNodesComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
