using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSummaryBlockDefinition
    {
        [JsonProperty("sortPriority")]
        public Int32 SortPriority { get; set; }
    }
}
