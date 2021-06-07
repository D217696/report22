using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DyeReference
    {
        [JsonProperty("channelHash")]
        public UInt32 ChannelHash { get; set; }
        [JsonProperty("dyeHash")]
        public UInt32 DyeHash { get; set; }
    }
}
