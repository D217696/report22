using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Responses;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent
    {
        [JsonProperty("data")]
        public Dictionary<UInt32, PersonalDestinyVendorSaleItemSetComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
