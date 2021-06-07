using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent
    {
        [JsonProperty("data")]
        public Dictionary<UInt32, DestinyItemPlugComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
