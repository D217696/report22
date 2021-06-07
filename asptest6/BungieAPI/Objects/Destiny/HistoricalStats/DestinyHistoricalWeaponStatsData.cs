using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyHistoricalWeaponStatsData
    {
        [JsonProperty("weapons")]
        public DestinyHistoricalWeaponStats[] Weapons { get; set; }
    }
}
