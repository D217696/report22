using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorItemSocketOverride
    {
        [JsonProperty("singleItemHash")]
        public UInt32 SingleItemHash { get; set; }
        [JsonProperty("randomizedOptionsCount")]
        public Int32 RandomizedOptionsCount { get; set; }
        [JsonProperty("socketTypeHash")]
        public UInt32 SocketTypeHash { get; set; }
    }
}
