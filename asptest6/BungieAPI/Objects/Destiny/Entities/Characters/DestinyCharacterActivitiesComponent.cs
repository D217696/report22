using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Characters
{
    public class DestinyCharacterActivitiesComponent
    {
        [JsonProperty("dateActivityStarted")]
        public DateTime DateActivityStarted { get; set; }
        [JsonProperty("availableActivities")]
        public DestinyActivity[] AvailableActivities { get; set; }
        [JsonProperty("currentActivityHash")]
        public UInt32 CurrentActivityHash { get; set; }
        [JsonProperty("currentActivityModeHash")]
        public UInt32 CurrentActivityModeHash { get; set; }
        [JsonProperty("currentActivityModeType")]
        public Int32 CurrentActivityModeType { get; set; }
        [JsonProperty("currentActivityModeHashes")]
        public UInt32[] CurrentActivityModeHashes { get; set; }
        [JsonProperty("currentActivityModeTypes")]
        public UInt32[] CurrentActivityModeTypes { get; set; }
        [JsonProperty("currentPlaylistActivityHash")]
        public UInt32 CurrentPlaylistActivityHash { get; set; }
        [JsonProperty("lastCompletedStoryHash")]
        public UInt32 LastCompletedStoryHash { get; set; }
    }
}
