using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsActivity
    {
        [JsonProperty("referenceId")]
        public UInt32 ReferenceId { get; set; }
        [JsonProperty("directorActivityHash")]
        public UInt32 DirectorActivityHash { get; set; }
        [JsonProperty("instanceId")]
        public Int64 InstanceId { get; set; }
        [JsonProperty("mode")]
        public Int32 Mode { get; set; }
        [JsonProperty("modes")]
        public Int32[] Modes { get; set; }
        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }
        [JsonProperty("membershipType")]
        public Int32 MembershipType { get; set; }
    }
}
