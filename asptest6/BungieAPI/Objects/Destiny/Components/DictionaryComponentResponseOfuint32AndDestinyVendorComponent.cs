using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Vendors;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfuint32AndDestinyVendorComponent
    {
        [JsonProperty("data")]
        public Dictionary<UInt32, DestinyVendorComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
