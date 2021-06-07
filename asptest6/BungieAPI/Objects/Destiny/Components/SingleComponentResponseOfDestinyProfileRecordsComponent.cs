using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components.Records;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyProfileRecordsComponent
    {
        [JsonProperty("data")]
        public DestinyProfileRecordsComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
