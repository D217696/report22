using Newtonsoft.Json;
using NiobeLab.Core.Objects.Content;

namespace NiobeLab.Core.Objects.Trending
{
    public class TrendingEntryNews
    {
        [JsonProperty("article")]
        public ContentItemPublicContract Article { get; set; }
    }
}
