using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyEquipItemResults
    {
        [JsonProperty("equipResults")]
        public DestinyEquipItemResult[] EquipResults { get; set; }
    }
}
