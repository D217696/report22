using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupV2Card
    {
        [JsonProperty("groupId")]
        public Int64 GroupId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("groupType")]
        public Int32 GroupType { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("about")]
        public string About { get; set; }
        [JsonProperty("motto")]
        public string Motto { get; set; }
        [JsonProperty("memberCount")]
        public Int32 MemberCount { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("membershipOption")]
        public Int32 MembershipOption { get; set; }
        [JsonProperty("capabilities")]
        public Int32 Capabilities { get; set; }
        [JsonProperty("clanInfo")]
        public GroupV2ClanInfo ClanInfo { get; set; }
        [JsonProperty("avatarPath")]
        public string AvatarPath { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
    }
}
