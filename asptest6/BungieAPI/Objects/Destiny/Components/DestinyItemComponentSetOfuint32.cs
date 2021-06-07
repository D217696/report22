using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DestinyItemComponentSetOfuint32
    {
        [JsonProperty("instances")]
        public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent Instances { get; set; }
        [JsonProperty("perks")]
        public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent Perks { get; set; }
        [JsonProperty("renderData")]
        public DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent RenderData { get; set; }
        [JsonProperty("stats")]
        public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent Stats { get; set; }
        [JsonProperty("sockets")]
        public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent Sockets { get; set; }
        [JsonProperty("reusablePlugs")]
        public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }
        [JsonProperty("plugObjectives")]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }
        [JsonProperty("talentGrids")]
        public DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent TalentGrids { get; set; }
        [JsonProperty("plugStates")]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }
        [JsonProperty("objectives")]
        public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; set; }
    }
}
