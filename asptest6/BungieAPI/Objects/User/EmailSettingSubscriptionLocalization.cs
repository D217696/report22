using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.User
{
    public class EmailSettingSubscriptionLocalization
    {
        [JsonProperty("unknownUserDescription")]
        public string UnknownUserDescription { get; set; }
        [JsonProperty("registeredUserDescription")]
        public string RegisteredUserDescription { get; set; }
        [JsonProperty("unregisteredUserDescription")]
        public string UnregisteredUserDescription { get; set; }
        [JsonProperty("unknownUserActionText")]
        public string UnknownUserActionText { get; set; }
        [JsonProperty("knownUserActionText")]
        public string KnownUserActionText { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
