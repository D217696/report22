using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class RaidHash
    {
        [JsonProperty("hash")]
        public long Hash { get; set; }
        [JsonProperty("raid_id")]
        public int RaidId { get; set; }
    }
}
