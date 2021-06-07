using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyPublicMilestoneVendor
    {
        [JsonProperty("vendorHash")]
        public UInt32 vendorHash { get; set; }
        [JsonProperty("previewItemHash")]
        public UInt32 PreviewItemHash { get; set; }
    }
}
