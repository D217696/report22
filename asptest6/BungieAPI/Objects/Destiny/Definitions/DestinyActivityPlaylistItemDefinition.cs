using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityPlaylistItemDefinition
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("directActivityModeHash")]
        public UInt32 DirectActivityModeHash { get; set; }
        [JsonProperty("directActivityModeType")]
        public Int32 DirectActivityModeType { get; set; }
        [JsonProperty("activityModeHashes")]
        public UInt32[] ActivityModeHashes { get; set; }
        [JsonProperty("activityModeTypes")]
        public UInt32[] ActivityModeTypes { get; set; }
    }
}
