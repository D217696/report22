using Newtonsoft.Json;
using NiobeLab.Core.Objects.User;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Content
{
    public class ContentItemPublicContract
    {
        [JsonProperty("contentId")]
        public Int64 contentId { get; set; }
        [JsonProperty("cType")]
        public string CType { get; set; }
        [JsonProperty("cmsPath")]
        public string CmsPath { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("modifyDate")]
        public DateTime ModifyDate { get; set; }
        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }
        [JsonProperty("hasAgeGate")]
        public bool HasAgeGate { get; set; }
        [JsonProperty("minimumAge")]
        public Int32 MinimumAge { get; set; }
        [JsonProperty("ratingImagePath")]
        public string RatingImagePath { get; set; }
        [JsonProperty("author")]
        public GeneralUser Author { get; set; }
        [JsonProperty("autoEnglishPropertyFallback")]
        public bool AutoEnglishPropertyFallback { get; set; }
        [JsonProperty("properties")]
        public Dictionary<string, ContentRepresentation> Properties { get; set; }
        [JsonProperty("representations")]
        public ContentRepresentation[] Representations { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        [JsonProperty("commentSummary")]
        public CommentSummary CommentSummary { get; set; }
    }
}
