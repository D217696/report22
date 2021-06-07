using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Challenges;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyActivity
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("isNew")]
        public bool IsNew { get; set; }
        [JsonProperty("canLead")]
        public bool CanLead { get; set; }
        [JsonProperty("canJoin")]
        public bool CanJoin { get; set; }
        [JsonProperty("isCompleted")]
        public bool IsCompleted { get; set; }
        [JsonProperty("isVisible")]
        public bool IsVisible { get; set; }
        [JsonProperty("displayLevel")]
        public Int32 DisplayLevel { get; set; }
        [JsonProperty("recommendedLight")]
        public Int32 RecommendedLight { get; set; }
        [JsonProperty("difficultyTier")]
        public Int32 DifficultyTier { get; set; }
        [JsonProperty("challenges")]
        public DestinyChallengeStatus[] Challenges { get; set; }
        [JsonProperty("modifierHashes")]
        public UInt32[] ModifierHashes { get; set; }
        [JsonProperty("booleanActivityOptions")]
        public Dictionary<UInt32, bool> BooleanActivityOptions { get; set; }
        [JsonProperty("loadoutRequirementIndex")]
        public Int32 LoadoutRequirementIndex { get; set; }
    }
}
