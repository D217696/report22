﻿using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Milestones;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Endpoints
{
    public class GetPublicMilestoneContent
    {
        [JsonProperty("Response")]
        public DestinyMilestoneContent Response { get; set; }
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
