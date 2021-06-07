using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupResponse
    {
        [JsonProperty("detail")]
        public GroupV2 Detail { get; set; }
        [JsonProperty("founder")]
        public GroupMember Founder { get; set; }
        [JsonProperty("alliedIds")]
        public Int64[] AlliedIds { get; set; }
        [JsonProperty("parentGroup")]
        public GroupV2 ParentGroup { get; set; }
        [JsonProperty("allianceStatus")]
        public Int32 AllianceStatus { get; set; }
        [JsonProperty("groupJoinInviteCount")]
        public Int32 GroupJoinInviteCount { get; set; }
        [JsonProperty("currentUserMembershipsInactiveForDestiny")]
        public bool CurrentUserMembershipsInactiveForDestiny { get; set; }
        [JsonProperty("currentUserMemberMap")]
        public Dictionary<Int32, GroupMember> CurrentUserMemberMap { get; set; }
        [JsonProperty("currentUserPotentialMemberMap")]
        public Dictionary<Int32, GroupPotentialMember> currentUserPotentialMemberMap { get; set; }
    }
}
