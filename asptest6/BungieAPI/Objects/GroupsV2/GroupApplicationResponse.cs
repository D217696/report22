using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.GroupsV2
{
    public class GroupApplicationResponse
    {
        [JsonProperty("resolution")]
        public Int32 Resolution { get; set; }
    }
}
