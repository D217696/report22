using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyChecklistDefinition
    {
        [JsonProperty("displayProperties")]
        public Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("viewActionString")]
        public string ViewActionString { get; set; }
        [JsonProperty("scope")]
        public Int32 Scope { get; set; }
        [JsonProperty("entries")]
        public Checklists.DestinyChecklistEntryDefinition[] Entries { get; set; }
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("index")]
        public Int32 Index { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }
    }
}