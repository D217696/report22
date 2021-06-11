using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class Raid
    {
        [JsonProperty("raid_id")]
        public int RaidId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
    }
}
