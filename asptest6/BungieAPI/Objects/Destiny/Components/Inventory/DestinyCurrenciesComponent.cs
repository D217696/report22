using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Inventory
{
    public class DestinyCurrenciesComponent
    {
        [JsonProperty("itemQuantities")]
        public Dictionary<UInt32, Int32> ItemQuantities { get; set; }
    }
}
