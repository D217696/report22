using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyDefinition
    {
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("index")]
        public UInt32 Index { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }
    }
}
