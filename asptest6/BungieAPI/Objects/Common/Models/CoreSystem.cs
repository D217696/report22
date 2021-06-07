using Newtonsoft.Json;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Common.Models
{
    public class CoreSystem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("parameters")]
        public Dictionary<string, string> Parameters { get; set; }
    }
}
