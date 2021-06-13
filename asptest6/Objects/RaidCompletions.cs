using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class RaidCompletions
    {
        [JsonProperty("raid")]
        public Raid Raid { get; set; }
        [JsonProperty("three_mans")]
        public int ThreeMans { get; set; }
        [JsonProperty("two_mans")]
        public int TwoMans { get; set; }
        [JsonProperty("one_mans")]
        public int OneMans { get; set; }
        [JsonProperty("completions")]
        public List<Completion> Completions { get; set; }
    }
}
