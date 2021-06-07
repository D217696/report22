using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupV2
    {
        [JsonProperty("groupId")]
        public Int64 GroupId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("groupType")]
        public Int32 GroupType { get; set; }
        [JsonProperty("membershipIdCreated")]
        public Int64 MembershipIdCreated { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("modifcationDate")]
        public DateTime ModificationDate { get; set; }
        [JsonProperty("about")]
        public string About { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        [JsonProperty("memberCount")]
        public Int32 MemberCount { get; set; }
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
        [JsonProperty("isPublicTopicAdminOnly")]
        public bool IsPublicTopicAdminOnly { get; set; }
        [JsonProperty("motto")]
        public string Motto { get; set; }
        [JsonProperty("allowChat")]
        public bool AllowChat { get; set; }
        [JsonProperty("isDefaultPostPublic")]
        public bool IsDefaultPostPublic { get; set; }
        [JsonProperty("chatSecurity")]
        public Int32 CharSecurity { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("avatarImageIndex")]
        public Int32 AvatarImageIndex { get; set; }
        [JsonProperty("homepage")]
        public Int32 Homepage { get; set; }
        [JsonProperty("membershipOption")]
        public Int32 MembershipOption { get; set; }
        [JsonProperty("defaultPublicity")]
        public Int32 DefaultPublicity { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("bannerPath")]
        public string BannerPath { get; set; }
        [JsonProperty("avatarPath")]
        public string AvatarPath { get; set; }
        [JsonProperty("conversationId")]
        public Int64 ConversationId { get; set; }
        [JsonProperty("enableInvitationMessagingForAdmins")]
        public bool EnableInvitationMessagingForAdmins { get; set; }
        [JsonProperty("banExpireDate")]
        public DateTime BanExpireDate { get; set; }
        [JsonProperty("features")]
        public GroupFeatures Features { get; set; }
        [JsonProperty("clanInfo")]
        public GroupV2ClanInfoAndInvestment ClanInfo { get; set; }
    }
}
