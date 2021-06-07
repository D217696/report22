using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Forum
{
    public class PollResponse
    {
        [JsonProperty("topicId")]
        public Int64 TopicId { get; set; }
        [JsonProperty("results")]
        public PollResult[] Results { get; set; }
        [JsonProperty("totalVotes")]
        public Int32 TotalVotes { get; set; }
    }
}
