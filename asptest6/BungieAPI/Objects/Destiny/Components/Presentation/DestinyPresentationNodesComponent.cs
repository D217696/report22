using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Presentation
{
    public class DestinyPresentationNodesComponent
    {
        [JsonProperty("nodes")]
        public Dictionary<UInt32, DestinyPresentationNodeComponent> Nodes { get; set; }
    }
}
