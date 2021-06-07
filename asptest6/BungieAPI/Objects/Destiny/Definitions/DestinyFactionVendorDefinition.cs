using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyFactionVendorDefinition
    {
        [JsonProperty("vendorHash")]
        public UInt32 VendorHash { get; set; }
        [JsonProperty("destionationHash")]
        public UInt32 DestionationHash { get; set; }
        [JsonProperty("backgroundImagePath")]
        public string BackgroundImagePath { get; set; }
    }
}