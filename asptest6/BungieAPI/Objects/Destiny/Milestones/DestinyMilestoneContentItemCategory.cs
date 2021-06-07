using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneContentItemCategory
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("itemHashes")]
        public UInt32[] ItemHashes { get; set; }
    }
}
