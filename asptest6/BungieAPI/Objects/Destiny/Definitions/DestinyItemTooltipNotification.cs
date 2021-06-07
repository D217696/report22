using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemTooltipNotification
    {
        [JsonProperty("displayString")]
        public string DisplayString { get; set; }
        [JsonProperty("displayStyle")]
        public string displayStyle { get; set; }
    }
}
