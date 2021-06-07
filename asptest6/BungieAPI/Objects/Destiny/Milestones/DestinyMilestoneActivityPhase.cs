using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneActivityPhase
    {
        [JsonProperty("complete")]
        public bool Complete { get; set; }
        [JsonProperty("phaseHash")]
        public UInt32 PhaseHash { get; set; }
    }
}
