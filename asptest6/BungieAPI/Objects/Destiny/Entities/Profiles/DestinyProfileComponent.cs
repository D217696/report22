using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Profiles
{
    public class DestinyProfileComponent
    {
        [JsonProperty("userInfo")]
        public UserInfoCard UserInfo { get; set; }
        [JsonProperty("dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }
        [JsonProperty("versionsOwned")]
        public Int32 VersionsOwned { get; set; }
        [JsonProperty("characterIds")]
        public Int64[] CharacterIds { get; set; }
        [JsonProperty("seasonHashes")]
        public UInt32[] SeasonHashes { get; set; }
    }
}
