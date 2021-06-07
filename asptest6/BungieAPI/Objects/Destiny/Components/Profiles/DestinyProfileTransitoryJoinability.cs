using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Profiles
{
    public class DestinyProfileTransitoryJoinability
    {
        [JsonProperty("openSlots")]
        public Int32 OpenSlot { get; set; }
        [JsonProperty("privacySetting")]
        public Int32 PrivacySetting { get; set; }
        [JsonProperty("closedReasons")]
        public Int32 ClosedReasons { get; set; }
    }
}
