using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Applications
{
    public class Application
    {
        [JsonProperty("applicationType")]
        public Int32 ApplicationType { get; set; }
        [JsonProperty("applicationId")]
        public Int32 ApplicationId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("scope")]
        public Int64 Scope { get; set; }
        [JsonProperty("origin")]
        public string Origin { get; set; }
        [JsonProperty("status")]
        public Int32 status { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("statusChanged")]
        public DateTime StatusChanges { get; set; }
        [JsonProperty("firstPublished")]
        public DateTime FirstPublished { get; set; }
        [JsonProperty("team")]
        public ApplicationDeveloper[] Team { get; set; }
    }
}
