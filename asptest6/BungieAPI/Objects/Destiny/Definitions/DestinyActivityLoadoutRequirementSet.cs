using Newtonsoft.Json;

namespace NiobeLab.Core.Objects.Destiny.Definitions
{
    public class DestinyActivityLoadoutRequirementSet
    {
        [JsonProperty("requirements")]
        public DestinyActivityLoadoutRequirement[] Requirements { get; set; }
    }
}
