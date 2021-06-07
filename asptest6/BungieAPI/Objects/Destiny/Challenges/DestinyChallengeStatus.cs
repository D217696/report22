using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Quests;

namespace NiobeLab.Core.Objects.Destiny.Challenges
{
    public class DestinyChallengeStatus
    {
        [JsonProperty("objective")]
        public DestinyObjectiveProgress Objective { get; set; }
    }
}
