using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Items
{
    public class DestinyItemComponent
    {
        [JsonProperty("itemHash")]
        public UInt32 ItemHash { get; set; }
        [JsonProperty("itemInstanceId")]
        public Int64 ItemInstanceId { get; set; }
        [JsonProperty("quantity")]
        public Int32 Quantity { get; set; }
        [JsonProperty("bindStatus")]
        public Int32 BindStatus { get; set; }
        [JsonProperty("bucketHash")]
        public UInt32 BucketHash { get; set; }
        [JsonProperty("transferStatus")]
        public Int32 TransferStatus { get; set; }
        [JsonProperty("lockable")]
        public bool Lockable { get; set; }
        [JsonProperty("state")]
        public Int32 State { get; set; }
        [JsonProperty("overrideStyleItemHash")]
        public UInt32 OverriderStyleItemHash { get; set; }
        [JsonProperty("expirationDate")]
        public DateTime ExpirationDate { get; set; }
        [JsonProperty("isWrapper")]
        public bool IsWrapper { get; set; }
        [JsonProperty("tooltipNotificationIndexes")]
        public Int32[] TooltipNotificationIndexes { get; set; }
    }
}
