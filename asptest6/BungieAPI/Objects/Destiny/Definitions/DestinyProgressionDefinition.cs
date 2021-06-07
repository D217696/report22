using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Misc;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyProgressionDefinition
    {
        [JsonProperty("displayProperties")]
        public DestinyProgressionDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("scope")]
        public Int32 Scope { get; set; }
        [JsonProperty("repeatLastStep")]
        public bool RepeatLastStep { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("steps")]
        public DestinyProgressionStepDefinition[] Steps { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        [JsonProperty("factionHash")]
        public UInt32 FactionHash { get; set; }
        [JsonProperty("color")]
        public DestinyColor Color { get; set; }
        [JsonProperty("rankIcon")]
        public string RankIcon { get; set; }
        [JsonProperty("rewardItems")]
        public DestinyProgressionRewardItemQuantity[] RewardItems { get; set; }
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("index")]
        public Int32 Index { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }
    }
}
