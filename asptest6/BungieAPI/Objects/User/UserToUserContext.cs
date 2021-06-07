using Newtonsoft.Json;
using NiobeLab.Core.Objects.Ignores;
using System;

namespace NiobeLab.Core.Objects.User
{
    public class UserToUserContext
    {
        [JsonProperty("isFollowing")]
        public bool IsFollowing { get; set; }
        [JsonProperty("ignoreStatus")]
        public IgnoreResponse IgnoreStatus { get; set; }
        [JsonProperty("globalIgnoreEndDate")]
        public DateTime GlobalIgnoreEndDate { get; set; }
    }
}
