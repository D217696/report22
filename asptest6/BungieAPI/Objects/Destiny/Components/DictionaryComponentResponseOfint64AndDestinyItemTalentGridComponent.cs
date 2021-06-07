using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyItemTalentGridComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
