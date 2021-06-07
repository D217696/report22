using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemSackBlockDefinition
    {
        [JsonProperty("detailAction")]
        public string DetailAction { get; set; }
        [JsonProperty("openAction")]
        public string OpenAction { get; set; }
        [JsonProperty("selectItemCount")]
        public Int32 SelectItemCount { get; set; }
        [JsonProperty("vendorSackType")]
        public string VendorSackType { get; set; }
        [JsonProperty("openOnAquire")]
        public bool OpenOnAquire { get; set; }
    }
}
