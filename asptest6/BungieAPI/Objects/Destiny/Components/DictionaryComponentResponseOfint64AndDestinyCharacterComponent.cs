using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Characters;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyCharacterComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyCharacterComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
