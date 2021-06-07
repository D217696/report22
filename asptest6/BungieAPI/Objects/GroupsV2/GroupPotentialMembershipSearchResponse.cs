using Newtonsoft.Json;
using NiobeLab.Core.Objects.Queries;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupPotentialMembershipSearchResponse
    {
        [JsonProperty("results")]
        public GroupPotentialMembership[] Results { get; set; }
        [JsonProperty("totalResults")]
        public Int32 TotalResults { get; set; }
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
        [JsonProperty("query")]
        public PagedQuery Query { get; set; }
        [JsonProperty("replacementContinuationToken")]
        public string replacementContinuationToken { get; set; }
        [JsonProperty("useTotalProperty")]
        public bool UseTotalProperty { get; set; }
    }
}
