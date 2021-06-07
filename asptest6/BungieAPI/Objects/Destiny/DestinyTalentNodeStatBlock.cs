using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyTalentNodeStatBlock
    {
        [JsonProperty("currentStepStats")]
        public DestinyStat[] CurrentStepStats { get; set; }
        [JsonProperty("nextStepStats")]
        public DestinyStat[] NextStepStats { get; set; }
    }
}
