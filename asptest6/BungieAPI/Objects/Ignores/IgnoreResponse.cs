using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Ignores
{
    public class IgnoreResponse
    {
        [JsonProperty("isIgnored")]
        public bool IsIgnored { get; set; }
        [JsonProperty("ignoreFlags")]
        public Int32 IgnoreFlags { get; set; }
    }
}
