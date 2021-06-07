using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Perks;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemPerksComponent
    {
        [JsonProperty("perks")]
        public DestinyPerkReference[] Perks { get; set; }
    }
}