using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Animations
{
    public class DestinyAnimationReference
    {
        [JsonProperty("animName")]
        public string AnimName { get; set; }
        [JsonProperty("animIdentifier")]
        public string AnimIdentifier { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
