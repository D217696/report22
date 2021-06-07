using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemSocketState
    {
        [JsonProperty("plugHash")]
        public UInt32 PlugHash { get; set; }
        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
        [JsonProperty("isVisible")]
        public bool IsVisible { get; set; }
        [JsonProperty("enableFailIndexes")]
        public Int32[] EnableFailIndexes { get; set; }
    }
}
