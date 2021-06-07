using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSocketCategoryDefinition
    {
        [JsonProperty("socketCategoryHash")]
        public UInt32 SocketCategoryHash { get; set; }
        [JsonProperty("socketIndexes")]
        public Int32[] SocketIndexes { get; set; }
    }
}
