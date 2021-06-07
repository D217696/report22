using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyItemQuantity
    {
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("itemInstanceId")]
        public Int64 ItemInstanceId { get; set; }
        [JsonProperty("quantity")]
        public Int32 Quantity { get; set; }
    }
}
