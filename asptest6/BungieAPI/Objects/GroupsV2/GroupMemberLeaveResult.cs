using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupMemberLeaveResult
    {
        [JsonProperty("group")]
        public GroupV2 Group { get; set; }
        [JsonProperty("groupDeleted")]
        public bool GroupDeleted { get; set; }
    }
}
