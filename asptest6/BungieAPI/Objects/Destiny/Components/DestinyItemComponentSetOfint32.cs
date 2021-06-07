using BeepBoopBot.Core.Objects.Destiny.Components;
using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DestinyItemComponentSetOfint32
    {
        [JsonProperty("instances")]
        public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent Instances { get; set; }
        [JsonProperty("perks")]
        public DictionaryComponentResponseOfint32AndDestinyItemPerksComponent Perks { get; set; }
        [JsonProperty("renderData")]
        public DictionaryComponentResponseOfint32AndDestinyItemRenderComponent RenderData { get; set; }
        [JsonProperty("stats")]
        public DictionaryComponentResponseOfint32AndDestinyItemStatsComponent Stats { get; set; }
        [JsonProperty("sockets")]
        public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent Sockets { get; set; }
        [JsonProperty("reusablePlugs")]
        public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }
        [JsonProperty("plugObjectives")]
        public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }
        [JsonProperty("talentGrids")]
        public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent TalentGrids { get; set; }
        [JsonProperty("plugStates")]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }
        [JsonProperty("objectives")]
        public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Objectives { get; set; }
    }
}
