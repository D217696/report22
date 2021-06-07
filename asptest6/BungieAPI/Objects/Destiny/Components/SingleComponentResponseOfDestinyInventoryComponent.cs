using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Inventory;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyInventoryComponent
    {
        [JsonProperty("data")]
        public DestinyInventoryComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
