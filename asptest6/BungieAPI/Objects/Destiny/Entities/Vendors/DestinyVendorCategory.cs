using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Entities.Vendors
{
    public class DestinyVendorCategory
    {
        [JsonProperty("displayCategoryIndex")]
        public Int32 DisplayCategoryIndex { get; set; }
        [JsonProperty("itemIndexes")]
        public Int32[] ItemIndexes { get; set; }
    }
}
