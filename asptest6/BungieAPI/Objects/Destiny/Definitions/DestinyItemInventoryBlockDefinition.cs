using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemInventoryBlockDefinition
    {
        [JsonProperty("stackUniqueLabel")]
        public string StackUniqueLabel { get; set; }
        [JsonProperty("maxStackSize")]
        public Int32 MaxStackSize { get; set; }
        [JsonProperty("bucketTypeHash")]
        public UInt32 BucketTypeHash { get; set; }
        [JsonProperty("recoveryBucketTypeHash")]
        public UInt32 RecoveryBucketTypeHash { get; set; }
        [JsonProperty("tierTypeHash")]
        public UInt32 TierTypeHash { get; set; }
        [JsonProperty("isInstanceItem")]
        public bool IsInstanceItem { get; set; }
        [JsonProperty("tierTypeName")]
        public string TierTypeName { get; set; }
        [JsonProperty("tierType")]
        public string TierType { get; set; }
        [JsonProperty("expirationTooltip")]
        public string ExpirationTooltip { get; set; }
        [JsonProperty("expiredInActivityMessage")]
        public string ExpiredInActivityMessage { get; set; }
        [JsonProperty("expiredInOrbitMessage")]
        public string ExpiredInOrbitMessage { get; set; }
        [JsonProperty("suppressExpirationWhenObjectivesComplete")]
        public bool SuppressExpirationWhenObjectivesComplete { get; set; }
    }
}
