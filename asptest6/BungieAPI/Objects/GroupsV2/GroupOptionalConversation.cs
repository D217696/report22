using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupOptionalConversation
    {
        [JsonProperty("groupId")]
        public Int64 GroupId { get; set; }
        [JsonProperty("conversationId")]
        public Int64 ConversationId { get; set; }
        [JsonProperty("chatEnabled")]
        public bool ChatEnabled { get; set; }
        [JsonProperty("chatName")]
        public string ChatName { get; set; }
        [JsonProperty("chatSecurity")]
        public Int32 ChatSecurity { get; set; }
    }
}
