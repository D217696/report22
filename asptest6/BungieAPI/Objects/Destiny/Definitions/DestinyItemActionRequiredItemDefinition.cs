using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemActionRequiredItemDefinition
    {
        [JsonProperty("count")]
        public Int32 Count { get; set; }
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("deleteOnAction")]
        public bool DeleteOnAction { get; set; }
    }
}
