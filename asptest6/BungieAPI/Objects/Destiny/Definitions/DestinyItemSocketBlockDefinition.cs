using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSocketBlockDefinition
    {
        [JsonProperty("detail")]
        public string Details { get; set; }
        [JsonProperty("socketEntries")]
        public DestinyItemSocketEntryDefinition[] SocketEntries { get; set; }
        [JsonProperty("intrinsicSockets")]
        public DestinyItemIntrinsicSocketEntryDefinition[] IntrinsicSockets { get; set; }
        [JsonProperty("socketCategories")]
        public DestinyItemSocketCategoryDefinition[] SocketCategories { get; set; }
    }
}
