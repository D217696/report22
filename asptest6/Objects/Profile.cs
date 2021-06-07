using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class Profile
    { 
        [JsonProperty("membership_id")]
        public string MembershipId { get; set; }
        [JsonProperty("membership_type")]
        public int MembershipType { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("characters")]
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
