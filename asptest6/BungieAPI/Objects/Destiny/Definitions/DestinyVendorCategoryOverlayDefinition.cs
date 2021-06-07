using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorCategoryOverlayDefinition
    {
        [JsonProperty("choiceDescription")]
        public string ChoiceDescription { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("currencyItemHash")]
        public UInt32 CurrencyItemHash { get; set; }
    }
}
