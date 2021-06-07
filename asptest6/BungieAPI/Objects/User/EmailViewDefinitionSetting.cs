using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.User
{
    public class EmailViewDefinitionSetting
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("localization")]
        public Dictionary<string, EMailSettingLocalization> Localization { get; set; }
        [JsonProperty("setByDefault")]
        public bool SetByDefault { get; set; }
        [JsonProperty("optInAggregateValue")]
        public Int64 OptInAggregateValue { get; set; }
        [JsonProperty("subscriptions")]
        public EmailSubscriptionDefinition[] Subscriptions { get; set; }
    }
}
