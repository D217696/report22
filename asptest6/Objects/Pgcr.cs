using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class Pgcr
    {
        [JsonProperty("pcgr_id")]
        public long PcgrId { get; set; }
        [JsonProperty("pcgr")]
        public string Pcgr { get; set; }
        [JsonProperty("flawless")]
        public bool Flawless { get; set; }
        [JsonProperty("starting_phase_index")]
        public int StartingPhaseIndex { get; set; }
        [JsonProperty("raid_id")]
        public int RaidId { get; set; }
        [JsonProperty("player_count")]
        public int PlayerCount { get; set; }
    }
}
