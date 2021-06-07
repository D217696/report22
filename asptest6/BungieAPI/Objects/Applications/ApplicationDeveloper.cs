using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;

namespace NiobeLab.Core.Objects.Applications
{
    public class ApplicationDeveloper
    {
        [JsonProperty("role")]
        public Int32 Role { get; set; }
        [JsonProperty("apiEulaVersion")]
        public Int32 ApiEulaVersion { get; set; }
        [JsonProperty("user")]
        public UserInfoCard User { get; set; }
    }
}
