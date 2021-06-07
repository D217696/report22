using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent
    {
        [JsonProperty("data")]
        public Dictionary<UInt32, DestinyItemObjectivesComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
