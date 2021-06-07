using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Content.Models
{
    public class ContentTypeProperty
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("readableName")]
        public string ReadableName { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("propertyDescription")]
        public string PropertyDescription { get; set; }
        [JsonProperty("localizable")]
        public bool Localizabled { get; set; }
        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("order")]
        public Int32 Order { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        [JsonProperty("isTitle")]
        public bool IsTitle { get; set; }
        [JsonProperty("required")]
        public bool Required { get; set; }
        [JsonProperty("maxLength")]
        public Int32 MaxLength { get; set; }
        [JsonProperty("maxByteLength")]
        public Int32 MaxByteLength { get; set; }
        [JsonProperty("maxFileSize")]
        public Int32 MaxFileSize { get; set; }
        [JsonProperty("regexp")]
        public string Regexp { get; set; }
        [JsonProperty("validateAs")]
        public string ValidateAs { get; set; }
        [JsonProperty("rssAttribute")]
        public string RssAttribute { get; set; }
        [JsonProperty("visibleDependency")]
        public string VisibleDependency { get; set; }
        [JsonProperty("visibleOn")]
        public string VisibleOn { get; set; }
        [JsonProperty("dataType")]
        public Int32 DataType { get; set; }
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }
        [JsonProperty("childProperties")]
        public ContentTypeProperty[] ChildProperties { get; set; }
        [JsonProperty("contentTypeAllowed")]
        public string ContentTypeAllowed { get; set; }
        [JsonProperty("bindToProperty")]
        public string BindToProperty { get; set; }
        [JsonProperty("boundRegex")]
        public string BoundRegex { get; set; }
        [JsonProperty("representationSelection")]
        public Dictionary<string, string> RepresentationSelection { get; set; }
        [JsonProperty("defaultValues")]
        public ContentTypeDefaultValue DefaultValues { get; set; }
        [JsonProperty("isExternalAllowed")]
        public bool IsExternalAllowed { get; set; }
        [JsonProperty("propertySection")]
        public string PropertySection { get; set; }
        [JsonProperty("weight")]
        public Int32 Weight { get; set; }
        [JsonProperty("entityType")]
        public string EntityType { get; set; }
        [JsonProperty("isCombo")]
        public bool IsCombo { get; set; }
        [JsonProperty("suppressProperty")]
        public bool SuppressProperty { get; set; }
        [JsonProperty("legalContentTypes")]
        public string[] LegalContentTypes { get; set; }
        [JsonProperty("representationValidationString")]
        public string RepresenttionValidationString { get; set; }
        [JsonProperty("midWidth")]
        public Int32 MidWidth { get; set; }
        [JsonProperty("maxWidth")]
        public Int32 MaxWidth { get; set; }
        [JsonProperty("minHeight")]
        public Int32 MinHeight { get; set; }
        [JsonProperty("maxHeight")]
        public Int32 MaxHeight { get; set; }
        [JsonProperty("isVideo")]
        public bool IsVideo { get; set; }
        [JsonProperty("isImage")]
        public bool IsImage { get; set; }
    }
}
