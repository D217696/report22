using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Inventory
{
    public class DestinyPlatformSilverComponent
    {
        [JsonProperty("platformSilver")]
        public Dictionary<Int32, DestinyItemComponent> PlatformSilver { get; set; }
    }
}
