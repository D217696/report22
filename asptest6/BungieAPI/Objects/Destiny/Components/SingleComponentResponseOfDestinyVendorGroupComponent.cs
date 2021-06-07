using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Vendors;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyVendorGroupComponent
    {
        [JsonProperty("data")]
        public DestinyVendorGroupComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
