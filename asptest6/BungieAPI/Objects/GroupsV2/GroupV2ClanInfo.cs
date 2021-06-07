using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupV2ClanInfo
    {
        [JsonProperty("clanCallsign")]
        public string ClanCallsign { get; set; }
        [JsonProperty("clanBannerData")]
        public ClanBanner ClanBannerData { get; set; }
    }
}
