using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Quests;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemPlugObjectivesComponent
    {
        [JsonProperty("objectivesPerPlug")]
        public Dictionary<UInt32, DestinyObjectiveProgress[]> ObjectivesPerPlug { get; set; } //https://bungie-net.github.io/multi/schema_Destiny-Components-Items-DestinyItemPlugObjectivesComponent.html#schema_Destiny-Components-Items-DestinyItemPlugObjectivesComponent
    }
}
