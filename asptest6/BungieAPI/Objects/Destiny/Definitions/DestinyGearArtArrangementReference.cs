using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyGearArtArrangementReference
    {
        [JsonProperty("classHash")]
        public UInt32 ClassHash { get; set; }
        [JsonProperty("atArrangementHash")]
        public UInt32 AtArrangementHash { get; set; }
    }
}
