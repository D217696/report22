using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemSocketsComponent
    {
        [JsonProperty("sockets")]
        public DestinyItemSocketState[] Sockets { get; set; }
    }
}
