using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions.Common;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyDisplayCategoryDefinition
    {
        [JsonProperty("index")]
        public Int32 Index { get; set; }
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        [JsonProperty("displayCategoryHash")]
        public UInt32 DisplayCategoryHash { get; set; }
        [JsonProperty("displayProperties")]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        [JsonProperty("displayInBanner")]
        public bool DisplayInBanner { get; set; }
        [JsonProperty("progressionHash")]
        public UInt32 ProgressionHash { get; set; }
        [JsonProperty("sortOrder")]
        public Int32 SortOrder { get; set; }
        [JsonProperty("displayStyleHash")]
        public UInt32 DisplayStyleHash { get; set; }
        [JsonProperty("displayStyleIdentifier")]
        public string DisplayStyleIdentifier { get; set; }
    }
}
