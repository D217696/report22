using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class User
    {
        public User(int userId, string username)
        {
            UserID = userId;
            Username = username;
        }

        [JsonProperty("user_id")]
        public int UserID { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
