using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyCharacterResponse
    {
        [JsonProperty("inventory")]
        public SingleComponentResponseOfDestinyInventoryComponent Inventory { get; set; }
        [JsonProperty("character")]
        public SingleComponentResponseOfDestinyCharacterComponent Character { get; set; }
        [JsonProperty("progressions")]
        public SingleComponentResponseOfDestinyCharacterProgressionComponent Progressions { get; set; }
        [JsonProperty("renderData")]
        public SingleComponentResponseOfDestinyCharacterRenderComponent RenderData { get; set; }
        [JsonProperty("activities")]
        public SingleComponentResponseOfDestinyCharacterActivitiesComponent Activities { get; set; }
        [JsonProperty("equipment")]
        public SingleComponentResponseOfDestinyInventoryComponent Equipment { get; set; }
        [JsonProperty("kiosks")]
        public SingleComponentResponseOfDestinyKiosksComponent Kiosks { get; set; }
        [JsonProperty("plugSets")]
        public SingleComponentResponseOfDestinyPlugSetsComponent PlugSets { get; set; }
        [JsonProperty("presentationNodes")]
        public SingleComponentResponseOfDestinyPresentationNodesComponent PresentationNodes { get; set; }
        [JsonProperty("records")]
        public SingleComponentResponseOfDestinyCharacterRecordsComponent Records { get; set; }
        [JsonProperty("collectibles")]
        public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }
        [JsonProperty("itemComponents")]
        public DestinyItemComponentSetOfint64 ItemComponents { get; set; }
        [JsonProperty("uninstancedItemComponents")]
        public DestinyBaseItemComponentSetOfuint32 UninstancedItemComponents { get; set; }
        [JsonProperty("currencyLookups")]
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }
    }
}
