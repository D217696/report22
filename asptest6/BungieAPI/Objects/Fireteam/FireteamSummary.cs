using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Fireteam
{
    public class FireteamSummary
    {
        [JsonProperty("fireteamId")]
        public Int64 FireteamId { get; set; }
        [JsonProperty("groupId")]
        public Int64 GroupId { get; set; }
        [JsonProperty("platform")]
        public byte Platform { get; set; }
        [JsonProperty("activityType")]
        public Int32 ActivityType { get; set; }
        [JsonProperty("isImmediate")]
        public bool IsImmediate { get; set; }
        [JsonProperty("scheduledTime")]
        public DateTime ScheduledTime { get; set; }
        [JsonProperty("ownerMembershipId")]
        public Int64 OwnerMembershipId { get; set; }
        [JsonProperty("playerSlotCount")]
        public Int32 PlayerSlotCount { get; set; }
        [JsonProperty("alternateSlotCount")]
        public Int32 AlternateSlotCount { get; set; }
        [JsonProperty("availablePlayerSlotCount")]
        public Int32 AvailablePlayerSlotCount { get; set; }
        [JsonProperty("availableAlternateSlotCount")]
        public Int32 AvailableAlternateSlotCount { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }
        [JsonProperty("dateModified")]
        public DateTime DateModified { get; set; }
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }
        [JsonProperty("datePlayerModified")]
        public DateTime DatePlayerModified { get; set; }
    }
}
