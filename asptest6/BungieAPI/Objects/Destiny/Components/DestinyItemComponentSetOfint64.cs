using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DestinyItemComponentSetOfint64
    {
        [JsonProperty("instances")]
        public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent Instances { get; set; }
        [JsonProperty("perks")]
        public DictionaryComponentResponseOfint64AndDestinyItemPerksComponent Perks { get; set; }
        [JsonProperty("renderData")]
        public DictionaryComponentResponseOfint64AndDestinyItemRenderComponent RenderData { get; set; }
        [JsonProperty("stats")]
        public DictionaryComponentResponseOfint64AndDestinyItemStatsComponent Stats { get; set; }
        [JsonProperty("sockets")]
        public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent Sockets { get; set; }
        [JsonProperty("reusablePlugs")]
        public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; } // :(
        [JsonProperty("plugObjectives")]
        public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; } // :(
        [JsonProperty("talentGrids")]
        public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent TalentGrids { get; set; }
        [JsonProperty("plugStates")]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }
        [JsonProperty("objectives")]
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives { get; set; }
    }
}
