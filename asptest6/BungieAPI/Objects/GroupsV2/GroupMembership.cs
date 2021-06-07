using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupMembership
    {
        [JsonProperty("member")]
        public GroupMember Member { get; set; }
        [JsonProperty("group")]
        public GroupV2 Group { get; set; }
    }
}
