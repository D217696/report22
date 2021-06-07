using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Inventory;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyCurrenciesComponent
    {
        [JsonProperty("data")]
        public DestinyCurrenciesComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
