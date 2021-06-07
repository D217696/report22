using Newtonsoft.Json;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Config
{
    public class DestinyManifest
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("mobileAssetContentPath")]
        public string MobileAssetContentPath { get; set; }
        [JsonProperty("mobileGearAssetDataBases")]
        public GearAssetDataBaseDefinition[] MobileGearAssetDataBases { get; set; }
        [JsonProperty("mobileWorldContentPaths")]
        public Dictionary<string, string> MobileWorldConentPaths { get; set; }
        [JsonProperty("jsonWorldContentPaths")]
        public Dictionary<string, string> JsonWorldContentPaths { get; set; }
        [JsonProperty("jsonWorldComponentContentPaths")]
        public Dictionary<string, JsonWorldComponentContentPath> JsonWorldComponentContentPaths { get; set; }
        [JsonProperty("mobileClanBannerDatabasePath")]
        public string MobileClanBannerDatabasePath { get; set; }
        [JsonProperty("mobileGearCDN")]
        public Dictionary<string, string> MobileGearCDN { get; set; }
        [JsonProperty("iconImagePyramidInfo")]
        public ImagePyramidEntry[] IconImagePyramidInfo { get; set; }
    }
}
