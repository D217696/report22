using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Vendors;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyVendorComponent
    {
        [JsonProperty("data")]
        public DestinyVendorComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
