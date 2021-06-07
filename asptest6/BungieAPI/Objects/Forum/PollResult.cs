using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Forum
{
    public class PollResult
    {
        [JsonProperty("answerText")]
        public string AnswerText { get; set; }
        [JsonProperty("answerSlot")]
        public Int32 AnswerSlot { get; set; }
        [JsonProperty("lastVoteDate")]
        public DateTime LastVoteDate { get; set; }
        [JsonProperty("votes")]
        public Int32 Votes { get; set; }
        [JsonProperty("requestingUserVoted")]
        public bool RequestingUserVoted { get; set; }
    }
}
