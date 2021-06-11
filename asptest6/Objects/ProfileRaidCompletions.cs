using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class ProfileRaidCompletions
    {
        [JsonProperty("profile")]
        public Profile Profile { get; set; }
        [JsonProperty("raid_completions")]
        public List<RaidCompletions> RaidCompletions { get; set; } = new List<RaidCompletions>();
    }
}
