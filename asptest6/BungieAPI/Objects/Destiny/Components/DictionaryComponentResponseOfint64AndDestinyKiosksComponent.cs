using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Kiosks;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyKiosksComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyKiosksComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
