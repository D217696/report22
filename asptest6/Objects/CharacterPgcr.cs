using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class CharacterPgcr
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("character_id")]
        public string CharacterId { get; set; }
        [JsonProperty("pgcr_id")]
        public long pgcrId { get; set; }
        [JsonProperty("kills")]
        public int Kills { get; set; }
        [JsonProperty("deaths")]
        public int Deaths { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}
