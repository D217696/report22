using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Common.Models
{
    public class Destiny2CoreSettings
    {
        [JsonProperty("collectionRootNode")]
        public UInt32 CollectionRootNode { get; set; }
        [JsonProperty("badgesRootNode")]
        public UInt32 BadgesRootNode { get; set; }
        [JsonProperty("recordsRootNode")]
        public UInt32 RecordsRootNode { get; set; }
        [JsonProperty("medalsRootNode")]
        public UInt32 MedalsRootNode { get; set; }
        [JsonProperty("currentRankProgressionHashes")]
        public UInt32[] CurrentRankProgressionHashes { get; set; }
        [JsonProperty("undiscoveredCollectibleImage")]
        public string UndiscoveredCollectibleImage { get; set; }
        [JsonProperty("ammoTypeHeavyIcon")]
        public string AmmoTypeHeavyIcon { get; set; }
        [JsonProperty("ammoTypeSpecialIcon")]
        public string AmmoTypeSpecialIcon { get; set; }
        [JsonProperty("ammoTypePrimaryIcon")]
        public string AmmoTypePrimaryIcon { get; set; }
        [JsonProperty("currentSeasonalArtifactHash")]
        public UInt32 CurrentSeasonalArtifactHash { get; set; }
        [JsonProperty("currentSeasonHash")]
        public UInt32 CurrentSeasonHash { get; set; }
        [JsonProperty("futureSeasonHashes")]
        public UInt32[] FutureSeasonHashes { get; set; }
    }
}
