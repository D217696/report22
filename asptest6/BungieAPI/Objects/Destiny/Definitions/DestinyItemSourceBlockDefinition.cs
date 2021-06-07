using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions.Sources;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSourceBlockDefinition
    {
        [JsonProperty("sourceHashes")]
        public UInt32[] SourceHashes { get; set; }
        [JsonProperty("sources")]
        public DestinyItemSourceDefinition Sources { get; set; }
        [JsonProperty("exclusive")]
        public Int32 Exclusive { get; set; }
        [JsonProperty("vendorSources")]
        public DestinyItemVendorSourceReference[] VendorSources { get; set; }
    }
}
