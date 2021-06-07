using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorInteractionReplyDefinition
    {
        [JsonProperty("itemRewardsSelection")]
        public Int32 ItemRewardsSelection { get; set; }
        [JsonProperty("reply")]
        public string Reply { get; set; }
        [JsonProperty("replyType")]
        public Int32 ReplyType { get; set; }
    }
}
