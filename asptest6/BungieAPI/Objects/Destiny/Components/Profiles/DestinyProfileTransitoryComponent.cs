using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Profiles
{
    public class DestinyProfileTransitoryComponent
    {
        [JsonProperty("partyMembers")]
        public DestinyProfileTransitoryPartyMember[] PartyMembers { get; set; }
        [JsonProperty("currentActivity")]
        public DestinyProfileTransitoryCurrentActivity CurrentActivity { get; set; }
        [JsonProperty("joinability")]
        public DestinyProfileTransitoryJoinability Joinability { get; set; }
        [JsonProperty("tracking")]
        public DestinyProfileTransitoryTrackingEntry[] Tracking { get; set; }
        [JsonProperty("lastOrbitedDestinationHash")]
        public UInt32 LastOrbitedDestinationHash { get; set; }
    }
}
