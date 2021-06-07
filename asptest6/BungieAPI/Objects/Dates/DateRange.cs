using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Dates
{
    public class DateRange
    {
        [JsonProperty("start")]
        public DateTime Start { get; set; }
        [JsonProperty("end")]
        public DateTime end { get; set; }
    }
}
