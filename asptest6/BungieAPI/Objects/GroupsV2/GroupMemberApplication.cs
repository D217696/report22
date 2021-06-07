using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupMemberApplication
    {
        [JsonProperty("groupId")]
        public Int64 GroupId { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("resolveState")]
        public Int32 ResolveState { get; set; }
        [JsonProperty("resolveDate")]
        public DateTime ResolveDate { get; set; }
        [JsonProperty("resolvedByMembershipId")]
        public Int64 ResolveByMembershipId { get; set; }
        [JsonProperty("requestMessage")]
        public string RequestMessage { get; set; }
        [JsonProperty("resolveMessage")]
        public string ResolveMessage { get; set; }
        [JsonProperty("destinyUserInfo")]
        public GroupUserInfoCard DestinyUserInfo { get; set; }
        [JsonProperty("bungieNetUserInfo")]
        public UserInfoCard BungieNetUserInfo { get; set; }
    }
}
