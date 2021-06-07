using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemCreationEntryLevelDefinition
    {
        [JsonProperty("level")]
        public Int32 Level { get; set; }
    }
}
