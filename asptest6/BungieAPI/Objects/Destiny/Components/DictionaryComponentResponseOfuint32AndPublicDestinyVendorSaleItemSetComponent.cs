using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent
    {
        [JsonProperty("data")]
        public Dictionary<UInt32, PublicDestinyVendorSaleItemSetComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
