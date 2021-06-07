using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Destiny.Character
{
    public class DestinyCharacterCustomization
    {
        [JsonProperty("personality")]
        public UInt32 Personality { get; set; }
        [JsonProperty("face")]
        public UInt32 Face { get; set; }
        [JsonProperty("skinColor")]
        public UInt32 SkinColor { get; set; }
        [JsonProperty("lipColor")]
        public UInt32 LipColor { get; set; }
        [JsonProperty("eyeColor")]
        public UInt32 EyeColor { get; set; }
        [JsonProperty("hairColors")]
        public UInt32[] HairColors { get; set; }
        [JsonProperty("featureColors")]
        public UInt32[] FeatureColors { get; set; }
        [JsonProperty("decalColor")]
        public UInt32 DecalCololr { get; set; }
        [JsonProperty("wearHelmet")]
        public bool WearHelmet { get; set; }
        [JsonProperty("hairIndex")]
        public Int32 HairIndex { get; set; }
        [JsonProperty("featureIndex")]
        public Int32 FeatureIndex { get; set; }
        [JsonProperty("decalIndex")]
        public Int32 DecalIndex { get; set; }
    }
}
