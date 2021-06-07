using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyPublicMilestoneChallengeActivity
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("challengeObjectiveHashes")]
        public UInt32[] ChallengeObjectiveHashes { get; set; }
        [JsonProperty("modifierHashes")]
        public UInt32[] ModifierHashes { get; set; }
        [JsonProperty("loadoutRequirementIndex")]
        public Int32 LoadoutRequirementIndex { get; set; }
        [JsonProperty("phaseHashes")]
        public UInt32[] PhaseHashes { get; set; }
        [JsonProperty("booleanActivityOptions")]
        public Dictionary<UInt32, string> BooleanActivityOptions { get; set; }
    }
}
