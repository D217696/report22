using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiobeLab.Core.Objects.Destiny.Milestones
{
    public class DestinyMilestoneVendor
    {
        [JsonProperty("vendorHash")]
        public UInt32 VendorHash { get; set; }
        [JsonProperty("previewItemHash")]
        public UInt32 PreviewItemHash { get; set; }
    }
}
