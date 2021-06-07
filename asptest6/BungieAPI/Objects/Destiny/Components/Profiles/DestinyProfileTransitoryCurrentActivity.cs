using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Profiles
{
    public class DestinyProfileTransitoryCurrentActivity
    {
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }
        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }
        [JsonProperty("score")]
        public float Score { get; set; }
        [JsonProperty("highestOpposingFactionScore")]
        public float HighestOpposingFactionScore { get; set; }
        [JsonProperty("numberOfOpponents")]
        public Int32 NumberOfOpponents { get; set; }
        [JsonProperty("numberOfPlayers")]
        public Int32 NumberOfPlayers { get; set; }
    }
}
