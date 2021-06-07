using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.Destiny.HistoricalStats
{
    public class DestinyPlayer
    {
        [JsonProperty("destinyUserInfo")]
        public UserInfoCard DestinyUserInfo { get; set; }
        [JsonProperty("characterClass")]
        public string CharacterClass { get; set; }
        [JsonProperty("classHash")]
        public UInt32 ClassHash { get; set; }
        [JsonProperty("raceHash")]
        public UInt32 RaceHash { get; set; }
        [JsonProperty("genderHash")]
        public UInt32 GenderHash { get; set; }
        [JsonProperty("characterLevel")]
        public Int32 CharacterLevel { get; set; }
        [JsonProperty("lightLevel")]
        public Int32 LightLevel { get; set; }
        [JsonProperty("bungieNetUserInfo")]
        public UserInfoCard BungieNetUserInfo { get; set; }
        [JsonProperty("clanName")]
        public string ClanName { get; set; }
        [JsonProperty("clanTag")]
        public string ClanTag { get; set; }
        [JsonProperty("emblemHash")]
        public UInt32 EmblemHash { get; set; }
    }
}
