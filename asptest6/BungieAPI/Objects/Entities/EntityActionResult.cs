using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Entities
{
    public class EntityActionResult
    {
        [JsonProperty("entityId")]
        public Int64 EntityId { get; set; }
        [JsonProperty("result")]
        public Int32 Result { get; set; }
    }
}
