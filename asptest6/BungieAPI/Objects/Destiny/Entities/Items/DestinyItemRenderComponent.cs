using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemRenderComponent
    {
        [JsonProperty("useCustomDyes")]
        public bool UseCustomDyes { get; set; }
        [JsonProperty("artRegions")]
        public Dictionary<Int32, Int32> ArtRegions { get; set; }
    }
}
