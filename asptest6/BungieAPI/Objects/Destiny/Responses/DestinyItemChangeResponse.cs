using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyItemChangeResponse
    {
        [JsonProperty("item")]
        public DestinyItemResponse Item { get; set; }
        [JsonProperty("addedInventoryItems")]
        public DestinyItemComponent[] AddedInventoryItems { get; set; }
        [JsonProperty("removedInventoryItems")]
        public DestinyItemComponent[] RemovedInventoryItems { get; set; }
    }
}
