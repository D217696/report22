using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityInsertionPointDefinition
    {
        [JsonProperty("phaseHash")]
        public UInt32 PhaseHash { get; set; }
    }
}
