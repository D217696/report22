using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int32, DestinyItemTalentGridComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
