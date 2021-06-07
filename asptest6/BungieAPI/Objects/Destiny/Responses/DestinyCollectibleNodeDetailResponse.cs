using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyCollectibleNodeDetailResponse
    {
        [JsonProperty("collectibles")]
        public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }
        [JsonProperty("collectibleItemComponents")]
        public DestinyItemComponentSetOfuint32 CollectibleItemComponents { get; set; }
    }
}
