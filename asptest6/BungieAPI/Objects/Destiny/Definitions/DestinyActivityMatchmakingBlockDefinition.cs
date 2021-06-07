using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityMatchmakingBlockDefinition
    {
        [JsonProperty("isMatchmade")]
        public bool IsMatchmade { get; set; }
        [JsonProperty("minParty")]
        public Int32 MinParty { get; set; }
        [JsonProperty("maxParty")]
        public Int32 MaxParty { get; set; }
        [JsonProperty("maxPlayers")]
        public Int32 MaxPlayers { get; set; }
        [JsonProperty("requiresGuardianOath")]
        public bool RequiresGuardianOath { get; set; }
    }
}
