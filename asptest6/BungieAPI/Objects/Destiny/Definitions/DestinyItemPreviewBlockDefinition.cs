using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions.Items;
using System;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyItemPreviewBlockDefinition
    {
        [JsonProperty("screenStyle")]
        public string ScreenStyle { get; set; }
        [JsonProperty("previewVendorHash")]
        public UInt32 PreviewVendorHash { get; set; }
        [JsonProperty("artifactHash")]
        public UInt32 ArtifactHash { get; set; }
        [JsonProperty("previewActionString")]
        public string PreviewActionString { get; set; }
        [JsonProperty("derivedItemCategories")]
        public DestinyDerivedItemCategoryDefinition[] DerivedItemCategories { get; set; }
    }
}
