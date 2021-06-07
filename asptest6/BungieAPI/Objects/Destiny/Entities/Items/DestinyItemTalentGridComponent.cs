using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemTalentGridComponent
    {
        [JsonProperty("talentGridHash")]
        public UInt32 TalentGridHash { get; set; }
        [JsonProperty("nodes")]
        public DestinyTalentNode[] Nodes { get; set; }
        [JsonProperty("isGridComplete")]
        public bool IsGridComplete { get; set; }
        [JsonProperty("gridProgression")]
        public DestinyProgression GridProgression { get; set; }
    }
}
