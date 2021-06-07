using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components;
using System;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyItemResponse
    {
        [JsonProperty("characterId")]
        public Int64 CharacterId { get; set; }
        [JsonProperty("item")]
        public SingleComponentResponseOfDestinyItemComponent Item { get; set; }
        [JsonProperty("instance")]
        public SingleComponentResponseOfDestinyItemInstanceComponent Instance { get; set; }
        [JsonProperty("objectives")]
        public SingleComponentResponseOfDestinyItemObjectivesComponent Objectives { get; set; }
        [JsonProperty("perks")]
        public SingleComponentResponseOfDestinyItemPerksComponent Perks { get; set; }
        [JsonProperty("renderData")]
        public SingleComponentResponseOfDestinyItemRenderComponent RenderData { get; set; }
        [JsonProperty("stats")]
        public SingleComponentResponseOfDestinyItemStatsComponent Stats { get; set; }
        [JsonProperty("talentGrid")]
        public SingleComponentResponseOfDestinyItemTalentGridComponent TalentGrid { get; set; }
        [JsonProperty("sockets")]
        public SingleComponentResponseOfDestinyItemSocketsComponent Sockets { get; set; }
        [JsonProperty("reusablePlugs")]
        public SingleComponentResponseOfDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }
        [JsonProperty("plugObjectives")]
        public SingleComponentResponseOfDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }
    }
}
