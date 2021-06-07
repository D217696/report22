using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Quests;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Records
{
    public class DestinyRecordComponent
    {
        [JsonProperty("state")]
        public Int32 State { get; set; }
        [JsonProperty("objectives")]
        public DestinyObjectiveProgress[] Objectives { get; set; }
        [JsonProperty("invervalObjectives")]
        public DestinyObjectiveProgress[] IntervalObjectives { get; set; }
        [JsonProperty("intervalsRedeemedCount")]
        public Int32 IntervalsRedeemedCount { get; set; }
    }
}
