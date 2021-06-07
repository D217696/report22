using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyProgressionResetEntry
    {
        [JsonProperty("season")]
        public Int32 Season { get; set; }
        [JsonProperty("resets")]
        public Int32 Resets { get; set; }
    }
}
