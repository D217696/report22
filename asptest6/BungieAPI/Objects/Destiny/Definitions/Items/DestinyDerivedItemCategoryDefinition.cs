using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Items
{
    public class DestinyDerivedItemCategoryDefinition
    {
        [JsonProperty("categoryDescription")]
        public string CategoryDescription { get; set; }
        [JsonProperty("items")]
        public DestinyDerivedItemDefinition[] Items { get; set; }
    }
}
