using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyItemPlugObjectivesComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
