using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyUnlockStatus
    {
        [JsonProperty("unlockHash")]
        public UInt32 UnlockHash { get; set; }
        [JsonProperty("isSet")]
        public bool IsSet { get; set; }
    }
}
