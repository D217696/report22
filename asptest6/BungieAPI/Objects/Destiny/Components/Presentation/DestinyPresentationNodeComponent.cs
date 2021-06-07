using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Quests;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components.Presentation
{
    public class DestinyPresentationNodeComponent
    {
        [JsonProperty("state")]
        public Int32 State { get; set; }
        [JsonProperty("objective")]
        public DestinyObjectiveProgress Objective { get; set; }
        [JsonProperty("progressValue")]
        public Int32 ProgressValue { get; set; }
        [JsonProperty("completionValue")]
        public Int32 CompletionValue { get; set; }
    }
}
