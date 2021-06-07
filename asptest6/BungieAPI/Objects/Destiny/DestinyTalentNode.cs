using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Definitions;
using System;

namespace NiobeLab.Core.Objects.Destiny
{
    public class DestinyTalentNode
    {
        [JsonProperty("nodeIndex")]
        public Int32 NodeIndex { get; set; }
        [JsonProperty("nodeHash")]
        public UInt32 NodeHash { get; set; }
        [JsonProperty("state")]
        public Int32 State { get; set; }
        [JsonProperty("isActivated")]
        public bool IsActivated { get; set; }
        [JsonProperty("stepIndex")]
        public Int32 StepIndex { get; set; }
        [JsonProperty("materialsToUpgrade")]
        public DestinyMaterialRequirement[] MaterialsToUpgrade { get; set; }
        [JsonProperty("activationGridLevel")]
        public Int32 ActivationGridLevel { get; set; }
        [JsonProperty("progressPercent")]
        public float ProgressPercent { get; set; }
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
        [JsonProperty("nodeStatsBlock")]
        public DestinyTalentNodeStatBlock NodeStatsBlock { get; set; }
    }
}
