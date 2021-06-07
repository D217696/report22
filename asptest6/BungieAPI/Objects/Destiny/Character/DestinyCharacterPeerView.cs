using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Character
{
    public class DestinyCharacterPeerView
    {
        [JsonProperty("equipment")]
        public DestinyItemPeerView[] Equipment { get; set; }
    }
}
