using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorInteractionSackEntryDefinition
    {
        [JsonProperty("sackType")]
        public UInt32 SackType { get; set; }
    }
}
