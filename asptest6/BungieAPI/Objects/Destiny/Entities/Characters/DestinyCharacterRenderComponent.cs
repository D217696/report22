using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Character;

namespace NiobeLab.Core.Objects.Destiny.Entities.Characters
{
    public class DestinyCharacterRenderComponent
    {
        [JsonProperty("customDyes")]
        public DyeReference[] CustomDyes { get; set; }
        [JsonProperty("customization")]
        public DestinyCharacterCustomization Customization { get; set; }
        [JsonProperty("peerView")]
        public DestinyCharacterPeerView PeerView { get; set; }
    }
}
