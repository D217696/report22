using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Vendors;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent
    {
        [JsonProperty("data")]
        public Dictionary<UInt32, DestinyPublicVendorComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
