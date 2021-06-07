using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemReusablePlugsComponent
    {
        [JsonProperty("plugs")]
        public Dictionary<Int32, DestinyItemPlugComponent[]> Plugs { get; set; }
    }
}
