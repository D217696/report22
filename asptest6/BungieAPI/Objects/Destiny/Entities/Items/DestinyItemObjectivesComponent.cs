using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Quests;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemObjectivesComponent
    {
        [JsonProperty("objectives")]
        public DestinyObjectiveProgress[] Objectives { get; set; }
        [JsonProperty("flavorObjective")]
        public DestinyObjectiveProgress FlavorObjective { get; set; }
        [JsonProperty("dateCompleted")]
        public DateTime DateCompleted { get; set; }
    }
}
