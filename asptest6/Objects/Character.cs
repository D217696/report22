using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class Character
    {
        [JsonProperty("character_id")]
        public string CharacterId { get; set; }
        [JsonProperty("membership_id")]
        public string MembershipId { get; set; }
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}
