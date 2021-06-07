using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.User
{
    public class EmailOptInDefinition
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public Int64 Value { get; set; }
        [JsonProperty("setByDefault")]
        public bool SetByDefault { get; set; }
        [JsonProperty("dependendSubscriptions")]
        public EmailSubscriptionDefinition[] DependendSubscriptions { get; set; }
    }
}
