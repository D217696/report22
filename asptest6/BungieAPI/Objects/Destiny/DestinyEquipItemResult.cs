using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyEquipItemResult
    {
        [JsonProperty("itemInstanceId")]
        public Int64 ItemInstanceId { get; set; }
        [JsonProperty("equipStatus")]
        public Int32 EquipStatus { get; set; }
    }
}
