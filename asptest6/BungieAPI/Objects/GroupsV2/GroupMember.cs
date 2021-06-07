using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupMember
    {
        [JsonProperty("memberType")]
        public Int32 MemberType { get; set; }
        [JsonProperty("isOnline")]
        public bool IsOnline { get; set; }
        [JsonProperty("lastOnlineStatusChange")]
        public Int64 LastOnlineStatusChange { get; set; }
        [JsonProperty("groupId")]
        public Int64 GroupId { get; set; }
        [JsonProperty("destinyUserInfo")]
        public GroupUserInfoCard DestinyUserInfo { get; set; }
        [JsonProperty("bungieNetUserInfo")]
        public UserInfoCard BungieNetUserInfo { get; set; }
        [JsonProperty("joinDate")]
        public DateTime JoinDate { get; set; }
    }
}
