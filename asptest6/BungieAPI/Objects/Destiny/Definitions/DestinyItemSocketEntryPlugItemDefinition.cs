using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSocketEntryPlugItemDefinition
    {
        [JsonProperty("plugItemHash")]
        public UInt32 PlugItemHash { get; set; }
    }
}
