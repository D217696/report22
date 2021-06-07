using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Inventory;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyInventoryComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyInventoryComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
