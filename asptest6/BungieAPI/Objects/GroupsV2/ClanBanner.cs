using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class ClanBanner
    {
        [JsonProperty("decalId")]
        public UInt32 DecalId { get; set; }
        [JsonProperty("decalColorId")]
        public UInt32 DecalColorId { get; set; }
        [JsonProperty("decalBackgroundColorId")]
        public UInt32 DecalBackgroundColorId { get; set; }
        [JsonProperty("gonfalonId")]
        public UInt32 GonfalonId { get; set; }
        [JsonProperty("gonfalonColorId")]
        public UInt32 GonfalonColorId { get; set; }
        [JsonProperty("gonfalonDetailId")]
        public UInt32 GonfalonDetailId { get; set; }
        [JsonProperty("gonfalonDetailColorId")]
        public UInt32 GonfalonDetailColorId { get; set; }
    }
}
