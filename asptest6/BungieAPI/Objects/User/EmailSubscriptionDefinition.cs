using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.User
{
    public class EmailSubscriptionDefinition
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("localization")]
        public Dictionary<string, EmailSettingSubscriptionLocalization> Localization { get; set; }
        [JsonProperty("value")]
        public Int64 Value { get; set; }
    }
}
