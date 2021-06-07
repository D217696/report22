using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Content.Models
{
    public class ContentTypeDescription
    {
        [JsonProperty("cType")]
        public string CType { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("contentDescription")]
        public string ContentDescription { get; set; }
        [JsonProperty("previewImage")]
        public string PreviewImage { get; set; }
        [JsonProperty("priority")]
        public Int32 Priority { get; set; }
        [JsonProperty("reminder")]
        public string Reminder { get; set; }
        [JsonProperty("properties")]
        public ContentTypeProperty[] Properties { get; set; }
        [JsonProperty("tagMetadata")]
        public TagMetadataDefinition[] TagMetadata { get; set; }
        [JsonProperty("tagMetadataItems")]
        public Dictionary<string, TagMetadataItem> TagMetadataItems { get; set; }
        [JsonProperty("usageExamples")]
        public string[] UsageExamples { get; set; }
        [JsonProperty("showInContentEditor")]
        public bool ShowInContentEditor { get; set; }
        [JsonProperty("typeOf")]
        public string TypeOf { get; set; }
        [JsonProperty("bindIdentifierToProperty")]
        public string BindIdentifierToProperty { get; set; }
        [JsonProperty("boundRegex")]
        public string BoundRegex { get; set; }
        [JsonProperty("forceIdentifierBinding")]
        public bool ForceIdentifierBinding { get; set; }
        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }
        [JsonProperty("autoEnglishPropertyFallback")]
        public bool AutoEnglishPropertyFallback { get; set; }
        [JsonProperty("bulkUploadable")]
        public bool BulkUploadable { get; set; }
        [JsonProperty("previews")]
        public ContentPreview[] Previews { get; set; }
        [JsonProperty("suppressCmsPath")]
        public bool SuppressCmsPath { get; set; }
        [JsonProperty("propertySections")]
        public ContentTypePropertySection[] PropertySections { get; set; }
    }
}
