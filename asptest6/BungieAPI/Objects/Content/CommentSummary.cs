using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Content
{
    public class CommentSummary
    {
        [JsonProperty("topicId")]
        public Int64 TopicId { get; set; }
        [JsonProperty("commentCount")]
        public Int32 CommentCount { get; set; }
    }
}
