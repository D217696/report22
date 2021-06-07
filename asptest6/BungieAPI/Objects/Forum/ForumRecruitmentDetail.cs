using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.Forum
{
    public class ForumRecruitmentDetail
    {
        [JsonProperty("topicId")]
        public Int64 TopicId { get; set; }
        [JsonProperty("microphoneRequired")]
        public bool MicrophoneRequired { get; set; }
        [JsonProperty("intensity")]
        public byte Intesity { get; set; }
        [JsonProperty("tone")]
        public byte Tone { get; set; }
        [JsonProperty("approved")]
        public bool Approved { get; set; }
        [JsonProperty("conversationId")]
        public Int64 ConversationId { get; set; }
        [JsonProperty("playerSlotsTotal")]
        public Int32 PlayerSlotsTotal { get; set; }
        [JsonProperty("playerSlotsRemaining")]
        public Int32 PlayerSlotsRemaining { get; set; }
        [JsonProperty("Fireteam")]
        public GeneralUser[] Fireteam { get; set; }
        [JsonProperty("kickedPlayerIds")]
        public Int64[] KickedPlayerIds { get; set; }
    }
}
