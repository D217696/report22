using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Inventory;
using System;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyProfileUserInfoCard
    {
        [JsonProperty("dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }
        [JsonProperty("isOverridden")]
        public bool IsOverridden { get; set; }
        [JsonProperty("isCrossSavePrimary")]
        public bool IsCrossSavePrimary { get; set; }
        [JsonProperty("platformSilver")]
        public DestinyPlatformSilverComponent PlatformSilver { get; set; }
        [JsonProperty("unpairedGameVersions")]
        public Int32 UnpairedGameVersion { get; set; }
        [JsonProperty("supplementalDisplayName")]
        public string SupplementalDisplayName { get; set; }
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("crossSaveOverride")]
        public Int32 CrossSaveOverride { get; set; }
        [JsonProperty("applicableMembershipTypes")]
        public Int32[] ApplicableMembershipTypes { get; set; }
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
        [JsonProperty("membershipType")]
        public Int32 MembershipType { get; set; }
        [JsonProperty("membershipId")]
        public Int64 MembershipId { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
