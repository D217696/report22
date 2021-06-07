using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Misc
{
    public class DestinyColor
    {
        [JsonProperty("red")]
        public byte Red { get; set; }
        [JsonProperty("green")]
        public byte Green { get; set; }
        [JsonProperty("blue")]
        public byte Blue { get; set; }
        [JsonProperty("alpha")]
        public byte Alpha { get; set; }
    }
}
