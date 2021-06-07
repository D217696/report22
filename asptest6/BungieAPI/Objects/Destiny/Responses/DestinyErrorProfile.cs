using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyErrorProfile
    {
        [JsonProperty("errorCode")]
        public Int32 ErrorCode { get; set; }
        [JsonProperty("infoCard")]
        public UserInfoCard InfoCard { get; set; }
    }
}
