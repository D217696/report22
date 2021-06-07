using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemGearsetBlockDefinition
    {
        [JsonProperty("trackingValueMax")]
        public Int32 TrackingValueMax { get; set; }
        [JsonProperty("itemList")]
        public UInt32[] ItemList { get; set; }
    }
}
