using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class RaidCompletions
    {
        [JsonProperty("name")]
        public string RaidName { get; set; }
        [JsonProperty("player_count")]
        public int PlayerCount { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
