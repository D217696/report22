using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Quests;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Items
{
    public class DestinyItemPlugComponent
    {
        [JsonProperty("plugObjectives")]
        public DestinyObjectiveProgress[] PlugObjectives { get; set; }
        [JsonProperty("plugItemHash")]
        public UInt32 PlugItemHash { get; set; }
        [JsonProperty("canInsert")]
        public bool CanInsert { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("insertFailIndexes")]
        public Int32[] InsertFailIndexes { get; set; }
        [JsonProperty("enableFailIndexes")]
        public Int32[] EnableFailIndexes { get; set; }
    }
}
