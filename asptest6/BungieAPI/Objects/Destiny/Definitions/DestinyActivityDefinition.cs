using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Constants;
using NiobeLab.Core.Objects.Destiny.Definitions.Common;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityDefinition
    {
        [JsonProperty("displayProperties")]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("originalDisplayProperties")]
        public DestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; set; }
        [JsonProperty("selectionScreenDisplayProperties")]
        public DestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties { get; set; }
        [JsonProperty("releaseIcon")]
        public string ReleaseIcon { get; set; }
        [JsonProperty("releaseTime")]
        public Int32 ReleaseTime { get; set; }
        [JsonProperty("activityLevel")]
        public Int32 ActivityLevel { get; set; }
        [JsonProperty("activityLightLevel")]
        public Int32 ActivityLightLevel { get; set; }
        [JsonProperty("destinationHash")]
        public UInt32 DestinationHash { get; set; }
        [JsonProperty("placeHash")]
        public UInt32 PlaceHash { get; set; }
        [JsonProperty("activityTypeHash")]
        public UInt32 ActivityTypeHash { get; set; }
        [JsonProperty("tier")]
        public Int32 Tier { get; set; }
        [JsonProperty("pcgrImage")]
        public string PcgrImage { get; set; }
        [JsonProperty("rewards")]
        public DestinyActivityRewardDefinition[] Rewards { get; set; }
        [JsonProperty("modifiers")]
        public DestinyActivityModifierReferenceDefinition[] Modifiers { get; set; }
        [JsonProperty("isPlaylist")]
        public bool IsPlaylist { get; set; }
        [JsonProperty("challenges")]
        public DestinyActivityChallengeDefinition[] Challenges { get; set; }
        [JsonProperty("optionalUnlockStrings")]
        public DestinyActivityUnlockStringDefinition[] OptionalUnlockStrings { get; set; }
        [JsonProperty("playlistItems")]
        public DestinyActivityPlaylistItemDefinition[] PlaylistItems { get; set; }
        [JsonProperty("activityGraphList")]
        public DestinyActivityGraphListEntryDefinition[] ActivityGraphList { get; set; }
        [JsonProperty("matchmaking")]
        public DestinyActivityMatchmakingBlockDefinition Matchmaking { get; set; }
        [JsonProperty("guidedGame")]
        public DestinyActivityGuidedBlockDefinition GuidedGame { get; set; }
        [JsonProperty("directActivityModeHash")]
        public UInt32 DirectActivityModeHash { get; set; }
        [JsonProperty("directActivityModeType")]
        public Int32 DirectActivityModeType { get; set; }
        [JsonProperty("loadouts")]
        public DestinyActivityLoadoutRequirementSet[] Loadouts { get; set; }
        [JsonProperty("activityModeHashes")]
        public UInt32[] ActivityModeHashes { get; set; }
        [JsonProperty("activityModeTypes")]
        public Int32[] ActivityModeTypes { get; set; }
        [JsonProperty("isPvP")]
        public bool IsPvp { get; set; }
        [JsonProperty("insertionPoints")]
        public DestinyActivityInsertionPointDefinition[] InsertionPoints { get; set; }
        [JsonProperty("activityLocationMappings")]
        public DestinyEnvironmentLocationMapping[] ActivityLocationMappings { get; set; }
        [JsonProperty("hash")]
        public UInt32 Hash { get; set; }
        [JsonProperty("index")]
        public UInt32 Index { get; set; }
        [JsonProperty("redacted")]
        public bool Redacted { get; set; }
    }
}
