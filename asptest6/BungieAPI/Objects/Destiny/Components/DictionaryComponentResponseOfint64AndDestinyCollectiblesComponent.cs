using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Collectibles;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyCollectiblesComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
