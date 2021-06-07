using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemStatsComponent
    {
        [JsonProperty("stats")]
        public Dictionary<UInt32, DestinyStat> Stats { get; set; }
    }
}
