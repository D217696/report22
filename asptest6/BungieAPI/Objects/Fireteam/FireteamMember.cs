using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.Fireteam
{
    public class FireteamMember
    {
        [JsonProperty("destinyUserInfo")]
        public FireteamUserInfoCard DestinyUserInfo { get; set; }
        [JsonProperty("bungieNetUserInfo")]
        public UserInfoCard BungieNetUserInfo { get; set; }
        [JsonProperty("characterId")]
        public Int64 CharacterId { get; set; }
        [JsonProperty("dateJoined")]
        public DateTime DateJoined { get; set; }
        [JsonProperty("hasMicrophone")]
        public bool HasMicrophone { get; set; }
        [JsonProperty("lastPlatformInviteAttemptDate")]
        public DateTime LastPlatformInviteattemptDate { get; set; }
        [JsonProperty("lastPlatformInviteAttemptResult")]
        public byte LastPlatfromInviteAttemptResult { get; set; }
    }
}
