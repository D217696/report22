using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Undefined
{
    public class GlobalAlert
    {
        [JsonProperty("AlertKey")]
        public string AlertKey { get; set; }
        [JsonProperty("AlertHtml")]
        public string AlertHtml { get; set; }
        [JsonProperty("AlertTimestamp")]
        public DateTime AlertTimestamp { get; set; }
        [JsonProperty("AlertLink")]
        public string AlertLink { get; set; }
        [JsonProperty("AlertLevel")]
        public Int32 AlertLevel { get; set; }
        [JsonProperty("AlertType")]
        public Int32 AlertType { get; set; }
        [JsonProperty("StreamInfo")]
        public StreamInfo StreamInfo { get; set; }
    }
}
