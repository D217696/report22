using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemIntrinsicSocketEntryDefinition
    {
        [JsonProperty("plugItemHash")]
        public UInt32 PlugItemHash { get; set; }
        [JsonProperty("socketTypeHash")]
        public UInt32 SocketTypeHash { get; set; }
        [JsonProperty("defaultVisible")]
        public bool DefaultVisible { get; set; }
    }
}
