using Newtonsoft.Json;
using NiobeLab.Core.Objects.Dates;

namespace NiobeLab.Core.Objects.Applications
{
    public class ApiUsage
    {
        [JsonProperty("range")]
        public DateRange Range { get; set; }
        [JsonProperty("apiCalls")]
        public Series[] ApiCalls { get; set; }
        [JsonProperty("throttledRequests")]
        public Series[] ThrottledRequests { get; set; }
    }
}
