using Newtonsoft.Json;
using NiobeLab.Core.Objects.GroupsV2;
using NiobeLab.Core.Objects.Queries;
using NiobeLab.Core.Objects.Tags.Models.Contracts;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.Forum
{
    public class PostSearchResponse
    {
        [JsonProperty("relatedPosts")]
        public PostResponse[] RelatedPosts { get; set; }
        [JsonProperty("authors")]
        public GeneralUser[] Authors { get; set; }
        [JsonProperty("groups")]
        public GroupResponse[] Groups { get; set; }
        [JsonProperty("searchedTags")]
        public TagResponse[] SearchedTags { get; set; }
        [JsonProperty("polls")]
        public PollResponse[] Polls { get; set; }
        [JsonProperty("recruitmentDetails")]
        public ForumRecruitmentDetail[] RecruitmentDetails { get; set; }
        [JsonProperty("availablePages")]
        public Int32 AvailablePages { get; set; }
        [JsonProperty("results")]
        public PostResponse[] Results { get; set; }
        [JsonProperty("totalResults")]
        public Int32 TotalResults { get; set; }
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
