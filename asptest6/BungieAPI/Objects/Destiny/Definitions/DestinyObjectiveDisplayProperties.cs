using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyObjectiveDisplayProperties
    {
        [JsonProperty("activityHash")]
        public UInt32 ActivityHash { get; set; }
        [JsonProperty("displayOnItemPreviewScreen")]
        public bool DisplayOnItemPreviewScreen { get; set; }
    }
}
