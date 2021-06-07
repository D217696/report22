using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSetBlockDefinition
    {
        [JsonProperty("itemList")]
        public DestinyItemSetBlockEntryDefinition[] ItemList { get; set; }
        [JsonProperty("requireOrderedSetItemAdd")]
        public bool RequireOrderedSetItemAdd { get; set; }
        [JsonProperty("setIsFeatured")]
        public bool SetIsFeatured { get; set; }
        [JsonProperty("setType")]
        public string SetType { get; set; }
    }
}
