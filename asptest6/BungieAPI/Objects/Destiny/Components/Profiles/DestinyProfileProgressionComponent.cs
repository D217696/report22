using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Artifacts;
using NiobeLab.Core.Objects.Destiny.Definitions;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Components.Profiles
{
    public class DestinyProfileProgressionComponent
    {
        [JsonProperty("checklists")]
        public Dictionary<UInt32, DestinyChecklistDefinition> Checklists { get; set; }
        [JsonProperty("seasonalArtifact")]
        public DestinyArtifactProfileScoped SeasonalArtifact { get; set; }
    }
}
