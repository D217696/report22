using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupBan
    {
        [JsonProperty("groupId")]
        public Int64 GroupId { get; set; }
        [JsonProperty("lastModifiedBy")]
        public UserInfoCard LastModifiedBy { get; set; }
        [JsonProperty("createdBy")]
        public UserInfoCard CreatedBy { get; set; }
        [JsonProperty("dateBanned")]
        public DateTime DateBanned { get; set; }
        [JsonProperty("dateExpires")]
        public DateTime DateExpires { get; set; }
        [JsonProperty("comment")]
        public string Comment { get; set; }
        [JsonProperty("bungieNetUserInfo")]
        public UserInfoCard BungieNetUserInfo { get; set; }
        [JsonProperty("destinyUserInfo")]
        public GroupUserInfoCard DestinyUserInfo { get; set; }
    }
}
