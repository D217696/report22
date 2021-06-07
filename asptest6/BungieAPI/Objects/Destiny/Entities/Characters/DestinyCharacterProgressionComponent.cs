using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Artifacts;
using NiobeLab.Core.Objects.Destiny.Definitions;
using NiobeLab.Core.Objects.Destiny.Milestones;
using NiobeLab.Core.Objects.Destiny.Progression;
using NiobeLab.Core.Objects.Destiny.Quests;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Entities.Characters
{
    public class DestinyCharacterProgressionComponent
    {
        [JsonProperty("progressions")]
        public Dictionary<UInt32, DestinyProgressionDefinition> Progressions { get; set; }
        [JsonProperty("factions")]
        public Dictionary<UInt32, DestinyFactionProgression> Factions { get; set; }
        [JsonProperty("milestones")]
        public Dictionary<UInt32, DestinyMilestone> Milestones { get; set; }
        [JsonProperty("quests")]
        public DestinyQuestStatus[] Quests { get; set; }
        [JsonProperty("uninstancedItemObjectives")]
        public Dictionary<UInt32, DestinyInventoryItemDefinition[]> UninstancedItemObjectives { get; set; }
        [JsonProperty("checklists")]
        public Dictionary<UInt32, DestinyChecklistDefinition> Checklists { get; set; }
        [JsonProperty("seasonalArtifact")]
        public DestinyArtifactCharacterScoped SeasonalArtifact { get; set; }
    }
}
