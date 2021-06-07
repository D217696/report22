using Newtonsoft.Json;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.User
{
    public class EmailSettings
    {
        [JsonProperty("optInDefinitions")]
        public Dictionary<string, EmailOptInDefinition> OptInDefinitions { get; set; }
        [JsonProperty("subscriptionDefinitions")]
        public Dictionary<string, EmailSubscriptionDefinition> SubscriptionDefinitions { get; set; }
        [JsonProperty("views")]
        public Dictionary<string, EmailViewDefinition> Views { get; set; }
    }
}
