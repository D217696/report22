using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSetBlockEntryDefinition
    {
        [JsonProperty("trackingValue")]
        public Int32 TrackingValue { get; set; }
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
    }
}
