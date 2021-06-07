using Newtonsoft.Json;
using System;

namespace NiobeLab.Core.Objects.Config
{
    public class UserTheme
    {
        [JsonProperty("userThemeId")]
        public Int32 UserThemeId { get; set; }
        [JsonProperty("userThemeName")]
        public string UserThemeName { get; set; }
        [JsonProperty("userThemeDescription")]
        public string UserThemeDescription { get; set; }
    }
}
