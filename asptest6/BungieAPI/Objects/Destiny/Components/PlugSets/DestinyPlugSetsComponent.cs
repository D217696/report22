using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Items;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.PlugSets
{
    public class DestinyPlugSetsComponent
    {
        [JsonProperty("plugs")]
        public Dictionary<UInt32, DestinyItemPlugComponent[]> Plugs { get; set; }
    }
}
