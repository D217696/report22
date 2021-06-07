using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyStat
    {
        [JsonProperty("statHash")]
        public UInt32 StatHash { get; set; }
        [JsonProperty("value")]
        public Int32 Value { get; set; }
    }
}
