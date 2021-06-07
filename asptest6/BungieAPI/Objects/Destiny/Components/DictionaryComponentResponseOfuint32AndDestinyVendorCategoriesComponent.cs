using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Vendors;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent
    {
        [JsonProperty("data")]
        public Dictionary<UInt32, DestinyVendorCategoriesComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
