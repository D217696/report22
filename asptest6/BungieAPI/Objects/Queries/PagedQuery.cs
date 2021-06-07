using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Queries
{
    public class PagedQuery
    {
        [JsonProperty("itemsPerPage")]
        public Int32 ItemsPerPage { get; set; }
        [JsonProperty("currentPage")]
        public Int32 CurrentPage { get; set; }
        [JsonProperty("requestContinuationToken")]
        public string RequestContinuationToken { get; set; }
    }
}
