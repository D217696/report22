using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Character
{
    public class DestinyItemPeerView
    {
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("dyes")]
        public DyeReference[] Dyes { get; set; }
    }
}
