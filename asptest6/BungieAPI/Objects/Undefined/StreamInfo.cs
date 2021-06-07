using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Undefined
{
    public class StreamInfo
    {
        [JsonProperty("ChannelName")]
        public string ChannelName { get; set; }
    }
}
