using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Misc;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Entities.Characters
{
    public class DestinyCharacterComponent
    {
        [JsonProperty("membershipId")]
        public Int64 MembershipId { get; set; }
        [JsonProperty("membershipType")]
        public Int32 MembershipType { get; set; }
        [JsonProperty("characterId")]
        public Int64 CharacterId { get; set; }
        [JsonProperty("dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }
        [JsonProperty("minutesPlayedThisSession")]
        public Int64 MinutesPlayedThisSession { get; set; }
        [JsonProperty("minutesPlayedTotal")]
        public Int64 MinutesPlayedTotal { get; set; }
        [JsonProperty("light")]
        public Int32 Light { get; set; }
        [JsonProperty("stats")]
        public Dictionary<UInt32, Int32> Stats { get; set; }
        [JsonProperty("raceHash")]
        public UInt32 RaceHash { get; set; }
        [JsonProperty("genderHash")]
        public UInt32 GenderHash { get; set; }
        [JsonProperty("classHash")]
        public UInt32 ClassHash { get; set; }
        [JsonProperty("raceType")]
        public Int32 RaceType { get; set; }
        [JsonProperty("classType")]
        public Int32 ClassType { get; set; }
        [JsonProperty("genderType")]
        public Int32 GenderType { get; set; }
        [JsonProperty("emblemPath")]
        public string EmblemPath { get; set; }
        [JsonProperty("emblemBackgroundPath")]
        public string EmblemBackgroundPath { get; set; }
        [JsonProperty("emblemHash")]
        public UInt32 EmblemHash { get; set; }
        [JsonProperty("emblemColor")]
        public DestinyColor EmblemColor { get; set; }
        [JsonProperty("levelProgression")]
        public DestinyProgression LevelProgression { get; set; }
        [JsonProperty("baseCharacterLevel")]
        public Int32 BaseCharacterLevel { get; set; }
        [JsonProperty("percentToNextLevel")]
        public float PercentToNextLevel { get; set; }
        [JsonProperty("titleRecordHash")]
        public UInt32 TitleRecordHash { get; set; }
    }
}
