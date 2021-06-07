using Newtonsoft.Json;
using NiobeLab.Core.Objects.Applications;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.App.Endpoints
{
    public class GetBungieApplications
    {
        [JsonProperty("Response")]
        public Application[] Response { get; set; }
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
