using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityModifierReferenceDefinition
    {
        [JsonProperty("activityModifierHash")]
        public UInt32 ActivityModifierHash { get; set; }
    }
}
