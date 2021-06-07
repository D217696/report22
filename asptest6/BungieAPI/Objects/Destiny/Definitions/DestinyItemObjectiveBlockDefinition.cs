using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemObjectiveBlockDefinition
    {
        [JsonProperty("objectiveHashes")]
        public UInt32[] ObjectiveHashes { get; set; }
        [JsonProperty("displayActivityHashes")]
        public UInt32[] DisplayActivityHashes { get; set; }
        [JsonProperty("requireFullObjectiveCompletion")]
        public bool RequireFullObjectiveCompletion { get; set; }
        [JsonProperty("questlineItemHash")]
        public UInt32 QuestlineItemHash { get; set; }
        [JsonProperty("narrative")]
        public string Narrative { get; set; }
        [JsonProperty("objectiveVerbName")]
        public string ObjectiveVerbName { get; set; }
        [JsonProperty("questTypeIdentifier")]
        public string QuestTypeIdentifier { get; set; }
        [JsonProperty("questTypeHash")]
        public UInt32 QuestTypeHash { get; set; }
        [JsonProperty("perObjectiveDisplayProperties")]
        public DestinyObjectiveDisplayProperties[] PerObjectiveDisplayProperties { get; set; }
    }
}
