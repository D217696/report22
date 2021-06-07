using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityGuidedBlockDefinition
    {
        [JsonProperty("guidedMaxLobbySize")]
        public Int32 GuidedMaxLobbySize { get; set; }
        [JsonProperty("guidedMinLobbySize")]
        public Int32 GuidedMinLobbySize { get; set; }
        [JsonProperty("guidedDisbandCount")]
        public Int32 GuidedDisbandCount { get; set; }
    }
}
