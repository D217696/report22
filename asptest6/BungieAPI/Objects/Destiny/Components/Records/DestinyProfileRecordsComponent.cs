using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Records
{
    public class DestinyProfileRecordsComponent
    {
        [JsonProperty("score")]
        public Int32 Score { get; set; }
        [JsonProperty("trackedRecordHash")]
        public UInt32 TrackedRecordHash { get; set; }
        [JsonProperty("records")]
        public Dictionary<UInt32, DestinyRecordComponent> Records { get; set; }
    }
}
