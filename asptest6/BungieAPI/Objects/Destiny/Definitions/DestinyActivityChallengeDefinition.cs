using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityChallengeDefinition
    {
        [JsonProperty("objectiveHash")]
        public UInt32 ObjectiveHash { get; set; }
        [JsonProperty("dummyRewards")]
        public DestinyItemQuantity[] DummyRewards { get; set; }
    }
}
