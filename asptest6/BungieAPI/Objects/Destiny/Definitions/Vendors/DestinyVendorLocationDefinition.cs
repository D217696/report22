using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions.Vendors
{
    public class DestinyVendorLocationDefinition
    {
        [JsonProperty("destinationHash")]
        public UInt32 DestionationHash { get; set; }
        [JsonProperty("backgroundImagePath")]
        public string BackgroundImagePath { get; set; }
    }
}
