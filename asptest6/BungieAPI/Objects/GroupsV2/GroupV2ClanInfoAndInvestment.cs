using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupV2ClanInfoAndInvestment
    {
        [JsonProperty("d2ClanProgressions")]
        public Dictionary<UInt32, DestinyProgression> D2ClanProgressions { get; set; }
        [JsonProperty("clanCallsign")]
        public string ClanCallsign { get; set; }
        [JsonProperty("clanBannerData")]
        public ClanBanner ClanBannerData { get; set; }
    }
}
