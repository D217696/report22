using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorServiceDefinition
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
