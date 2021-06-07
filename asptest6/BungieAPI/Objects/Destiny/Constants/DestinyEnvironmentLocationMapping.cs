using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Constants
{
    public class DestinyEnvironmentLocationMapping
    {
        [JsonProperty("locationHash")]
        public UInt32 LocationHash { get; set; }
        [JsonProperty("activationSource")]
        public string ActivationSource { get; set; }
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("objectiveHash")]
        public UInt32 ObjectiveHash { get; set; }
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
    }
}
