using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Fireteam
{
    public class FireteamResponse
    {
        [JsonProperty("Summary")]
        public FireteamSummary Summary { get; set; }
        [JsonProperty("Members")]
        public FireteamMember[] Members { get; set; }
        [JsonProperty("Alternates")]
        public FireteamMember Alternates { get; set; }
    }
}
