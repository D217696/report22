using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;

namespace NiobeLab.Core.Objects.Destiny.Entities.Inventory
{
    public class DestinyInventoryComponent
    {
        [JsonProperty("items")]
        public DestinyItemComponent[] Items { get; set; }
    }
}
