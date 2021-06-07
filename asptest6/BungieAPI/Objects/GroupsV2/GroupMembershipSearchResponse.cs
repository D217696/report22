using Newtonsoft.Json;
using NiobeLab.Core.Objects.Queries;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupMembershipSearchResponse
    {
        [JsonProperty("results")]
        public GroupMembership[] Results { get; set; }
        [JsonProperty("totalResult")]
        public Int32 TotalResult { get; set; }
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
        [JsonProperty("query")]
        public PagedQuery Query { get; set; }
        [JsonProperty("replacementContinuationToken")]
        public string ReplacementContinuationToken { get; set; }
        [JsonProperty("useTotalResults")]
        public bool UseTotalResults { get; set; }
    }
}
