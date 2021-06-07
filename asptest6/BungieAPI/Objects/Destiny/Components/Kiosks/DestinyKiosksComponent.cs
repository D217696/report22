using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Kiosks
{
    public class DestinyKiosksComponent
    {
        [JsonProperty("kioskItems")]
        public Dictionary<UInt32, DestinyVendorDefinition[]> KioskItems { get; set; }
    }
}
