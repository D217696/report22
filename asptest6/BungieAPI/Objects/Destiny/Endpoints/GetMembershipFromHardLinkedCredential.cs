using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiobeLab.Core.Objects.Destiny.Endpoints
{
    public class GetMembershipFromHardLinkedCredential
    {
        [JsonProperty("Response")]
        public HardLinkedUserMembership Response { get; set; }
        [JsonProperty("ErrorCode")]
        public Int32 ErrorCode { get; set; }
        [JsonProperty("ThrottleSeconds")]
        public Int32 ThrottleSeconds { get; set; }
        [JsonProperty("ErrorStatus")]
        public string ErrorStatus { get; set; }
        [JsonProperty("Message")]
        public string Message { get; set; }
        [JsonProperty("MessageData")]
        public Dictionary<string, string> MessageData { get; set; }
        [JsonProperty("DetailedErrorTrace")]
        public string DetailedErrorTrace { get; set; }
    }
}
