using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class Completion
    {
        [JsonProperty("pgcr_id")]
        public long PcgrId { get; set; }
        [JsonProperty("pgcr")]
        public string PgcrString { get; set; }
        [JsonProperty("flawless")]
        public bool Flawless { get; set; }
        [JsonProperty("starting_phase_index")]
        public int StartingPhaseIndex { get; set; }
        [JsonProperty("raid_id")]
        public int RaidId { get; set; }
        [JsonProperty("player_count")]
        public int PlayerCount { get; set; }
        [JsonProperty("character_id")]
        public string CharacterId { get; set; }
        [JsonProperty("kills")]
        public int Kills { get; set; }
        [JsonProperty("deaths")]
        public int Deaths { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}
