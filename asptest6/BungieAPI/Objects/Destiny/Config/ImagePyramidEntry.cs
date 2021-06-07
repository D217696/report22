using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Config
{
    public class ImagePyramidEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("factor")]
        public float Factor { get; set; }
    }
}
