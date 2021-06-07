using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Records
{
    public class DestinyCharacterRecordsComponent
    {
        [JsonProperty("featuredRecordHashes")]
        public UInt32[] FeaturedRecordHashes { get; set; }
        [JsonProperty("records")]
        public Dictionary<UInt32, DestinyRecordComponent> Records { get; set; }
    }
}
