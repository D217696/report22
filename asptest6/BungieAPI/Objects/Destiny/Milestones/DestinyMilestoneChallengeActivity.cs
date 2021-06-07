using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Challenges;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneChallengeActivity
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("challenges")]
        public DestinyChallengeStatus[] Challenges { get; set; }
        [JsonProperty("modifierHashes")]
        public UInt32[] ModifierHashes { get; set; }
        [JsonProperty("booleanActivityOptions")]
        public Dictionary<UInt32, bool> BooleanActivityOptions { get; set; }
        [JsonProperty("loadoutRequirementIndex")]
        public Int32 LoadoutRequirementIndex { get; set; }
        [JsonProperty("phases")]
        public DestinyMilestoneActivityPhase[] Phases { get; set; }
    }
}