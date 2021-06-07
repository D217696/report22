using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityGraphListEntryDefinition
    {
        [JsonProperty("activityGraphHash")]
        public UInt32 ActivityGraphHash { get; set; }
    }
}
