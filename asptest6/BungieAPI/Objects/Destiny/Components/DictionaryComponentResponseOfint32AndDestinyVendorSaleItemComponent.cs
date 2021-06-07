using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int32, DestinyVendorSaleItemComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
