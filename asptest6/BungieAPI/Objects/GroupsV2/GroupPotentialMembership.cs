using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupPotentialMembership
    {
        [JsonProperty("member")]
        public GroupPotentialMember Member { get; set; }
        [JsonProperty("group")]
        public GroupV2 Group { get; set; }
    }
}
