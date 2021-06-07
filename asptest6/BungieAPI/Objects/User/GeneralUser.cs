using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.User
{
    public class GeneralUser
    {
        [JsonProperty("membershipId")]
        public Int64 MembershipId { get; set; }
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }
        [JsonProperty("normalizedName")]
        public string NormalizedName { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("profilePicture")]
        public Int32 ProfilePicture { get; set; }
        [JsonProperty("profileTheme")]
        public Int32 ProfileTheme { get; set; }
        [JsonProperty("userTitle")]
        public Int32 UserTitle { get; set; }
        [JsonProperty("successMessageFlags")]
        public Int64 SuccessMessageFlags { get; set; }
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
        [JsonProperty("about")]
        public string About { get; set; }
        [JsonProperty("firstAccess")]
        public DateTime FirstAccess { get; set; }
        [JsonProperty("lastUpdate")]
        public DateTime LastUpdate { get; set; }
        [JsonProperty("legacyPortalUID")]
        public Int64 LegacyPortalUID { get; set; }
        [JsonProperty("context")]
        public UserToUserContext Context { get; set; }
        [JsonProperty("psnDisplayName")]
        public string PsnDisplayName { get; set; }
        [JsonProperty("xboxDisplayName")]
        public string XboxDisplayName { get; set; }
        [JsonProperty("fbDisplayName")]
        public string FbDisplayName { get; set; }
        [JsonProperty("showActivity")]
        public bool ShowActivity { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("localeInheritDefault")]
        public bool LocaleInheritDefault { get; set; }
        [JsonProperty("lastBanReportId")]
        public Int64 LastBanReportId { get; set; }
        [JsonProperty("showGroupMessaging")]
        public bool ShowGroupMessaging { get; set; }
        [JsonProperty("profilePicturePath")]
        public string ProfilePicturePath { get; set; }
        [JsonProperty("profilePictureWidePath")]
        public string ProfilePictureWidePath { get; set; }
        [JsonProperty("profileThemeName")]
        public string ProfileThemeName { get; set; }
        [JsonProperty("userTitleDisplay")]
        public string UserTitleDisplay { get; set; }
        [JsonProperty("statusText")]
        public string StatusText { get; set; }
        [JsonProperty("statusDate")]
        public DateTime StatusDate { get; set; }
        [JsonProperty("profileBanExpire")]
        public DateTime ProfileBanExpire { get; set; }
        [JsonProperty("blizzardDisplayName")]
        public string BlizzardDisplayName { get; set; }
        [JsonProperty("steamDisplayName")]
        public string SteamDisplayName { get; set; }
        [JsonProperty("stadiaDisplayName")]
        public string StadiaDisplayName { get; set; }
    }
}
