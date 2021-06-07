using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;
using System.Collections.Generic;

namespace BeepBoopBot.Core.Objects.Destiny.Components
{
    public class DictionaryComponentResponseOfint32AndDestinyItemRenderComponent
    {
        [JsonProperty("data")]
        public Dictionary<Int32, DestinyItemRenderComponent> Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
