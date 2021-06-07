using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Checklists
{
    public class DestinyChecklistEntryDefinition
    {
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("displayProperties")]
        public Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("destinationHash")]
        public UInt32 DestinationHash { get; set; }
        [JsonProperty("locationHash")]
        public UInt32 LocationHash { get; set; }
        [JsonProperty("bubbleHash")]
        public UInt32 BubbleHash { get; set; }
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("vendorHash")]
        public UInt32 VendorHash { get; set; }
        [JsonProperty("scope")]
        public Int32 Scope { get; set; }
    }
}
