using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Quests
{
    public class DestinyQuestStatus
    {
        [JsonProperty("questHash")]
        public UInt32 QuestHash { get; set; }
        [JsonProperty("stepHash")]
        public UInt32 StepHash { get; set; }
        [JsonProperty("stepObjectives")]
        public DestinyObjectiveProgress[] StepObjectives { get; set; }
        [JsonProperty("tracked")]
        public bool Tracked { get; set; }
        [JsonProperty("itemInstanceId")]
        public Int64 ItemInstanceId { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
        [JsonProperty("redeemed")]
        public bool Redeemed { get; set; }
        [JsonProperty("started")]
        public bool Started { get; set; }
        [JsonProperty("vendorHash")]
        public UInt32 VendorHash { get; set; }
    }
}
