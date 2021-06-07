using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Applications
{
    public class Datapoint
    {
        [JsonProperty("time")]
        public DateTime Tinme { get; set; }
        [JsonProperty("count")]
        public double Count { get; set; }
    }
}
