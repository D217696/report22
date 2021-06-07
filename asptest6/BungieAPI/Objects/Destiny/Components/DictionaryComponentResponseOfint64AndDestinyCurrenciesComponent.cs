using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Inventory;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int64, DestinyCurrenciesComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
