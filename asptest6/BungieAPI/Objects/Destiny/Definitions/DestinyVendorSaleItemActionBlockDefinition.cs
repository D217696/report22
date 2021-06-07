using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyVendorSaleItemActionBlockDefinition
    {
        [JsonProperty("executeSeconds")]
        public float ExecuteSeconds { get; set; }
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
    }
}
