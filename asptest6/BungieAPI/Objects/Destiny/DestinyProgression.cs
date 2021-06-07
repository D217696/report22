using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyProgression
    {
        [JsonProperty("progressionHash")]
        public UInt32 ProgressinHash { get; set; }
        [JsonProperty("dailyProgress")]
        public Int32 DailyProgress { get; set; }
        [JsonProperty("dailyLimit")]
        public Int32 DailyLimit { get; set; }
        [JsonProperty("weeklyProgress")]
        public Int32 WeeklyProgress { get; set; }
        [JsonProperty("weeklyLimit")]
        public Int32 WeeklyLimit { get; set; }
        [JsonProperty("currentProgress")]
        public Int32 CurrentProgress { get; set; }
        [JsonProperty("level")]
        public Int32 Level { get; set; }
        [JsonProperty("levelCap")]
        public Int32 LevelCap { get; set; }
        [JsonProperty("stepIndex")]
        public Int32 StepIndex { get; set; }
        [JsonProperty("progressToNextLevel")]
        public Int32 ProgressToNextLevel { get; set; }
        [JsonProperty("nextLevelAt")]
        public Int32 NextLevelAt { get; set; }
        [JsonProperty("currentResetCount")]
        public Int32 CurrentResetCount { get; set; }
        [JsonProperty("seasonResets")]
        public DestinyProgressionResetEntry SeasonResets { get; set; }
        [JsonProperty("rewardItemStates")]
        public Int32[] RewardItemStates { get; set; }
    }
}
