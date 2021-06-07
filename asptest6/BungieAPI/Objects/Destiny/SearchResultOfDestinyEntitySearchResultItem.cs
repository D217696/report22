﻿using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions;
using NiobeLab.Core.Objects.Queries;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class SearchResultOfDestinyEntitySearchResultItem
    {
        [JsonProperty("result")]
        public DestinyEntitySearchResultItem[] Results { get; set; }
        [JsonProperty("totalResults")]
        public Int32 TotalResults { get; set; }
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
        [JsonProperty("query")]
        public PagedQuery Query { get; set; }
        [JsonProperty("replacementContinuationToken")]
        public string ReplacementContinuationToken { get; set; }
        [JsonProperty("useTotalResults")]
        public bool UseTotalResults { get; set; }
    }
}
