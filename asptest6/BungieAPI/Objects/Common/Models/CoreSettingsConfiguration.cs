using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Common.Models
{
    public class CoreSettingsConfiguration
    {
        [JsonProperty("environment")]
        public string Environment { get; set; }
        [JsonProperty("systems")]
        public Dictionary<string, CoreSystem> Systems { get; set; }
        [JsonProperty("ignoreReason")]
        public CoreSetting[] IgnoreReason { get; set; }
        [JsonProperty("forumCategories")]
        public CoreSetting[] ForumCategories { get; set; }
        [JsonProperty("groupAvatars")]
        public CoreSetting[] GroupAvatars { get; set; }
        [JsonProperty("destinyMembershipTypes")]
        public CoreSetting[] DestinyMembershipTypes { get; set; }
        [JsonProperty("recruitmentPlatformTags")]
        public CoreSetting[] RecruitmentPlatformTags { get; set; }
        [JsonProperty("recruitmentMiscTags")]
        public CoreSetting[] RecruitmentMiscTags { get; set; }
        [JsonProperty("recruitmentActivities")]
        public CoreSetting[] RecruitmentActivities { get; set; }
        [JsonProperty("userContentLocales")]
        public CoreSetting[] UserContentLocales { get; set; }
        [JsonProperty("systemContentLocales")]
        public CoreSetting[] SystemContentLocales { get; set; }
        [JsonProperty("clanBannerDecals")]
        public CoreSetting[] ClanBannerDecals { get; set; }
        [JsonProperty("clanBannerDecalColors")]
        public CoreSetting[] ClanBannerDecalColors { get; set; }
        [JsonProperty("clanBannerGonfalons")]
        public CoreSetting[] ClanBannerGonfalons { get; set; }
        [JsonProperty("clanBannerGonfalonColors")]
        public CoreSetting[] ClanBannerGonfalonColors { get; set; }
        [JsonProperty("clanBannerGonfalonDetails")]
        public CoreSetting[] ClanBannerGonfalonDetails { get; set; }
        [JsonProperty("clanBannerGonfalonDetailColors")]
        public CoreSetting[] ClanBannerGonfalonDetailColors { get; set; }
        [JsonProperty("clanBannerStandards")]
        public CoreSetting[] ClanBannerStandards { get; set; }
        [JsonProperty("destiny2CoreSettings")]
        public Destiny2CoreSettings Destiny2CoreSettings { get; set; }
        [JsonProperty("emailSettings")]
        public EmailSettings EmailSettings { get; set; }
    }
}
