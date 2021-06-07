using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Records;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyCharacterRecordsComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privcay { get; set; }
    }
}
