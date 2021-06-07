using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class DestinyBaseItemComponentSetOfuint32
    {
        [JsonProperty("objectives")]
        public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; set; }
    }
}
