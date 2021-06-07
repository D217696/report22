﻿using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Entities.Items;
using System;

namespace NiobeLab.Core.Objects.Destiny.Components
{
    public class SingleComponentResponseOfDestinyItemPerksComponent
    {
        [JsonProperty("data")]
        public DestinyItemPerksComponent Data { get; set; }
        [JsonProperty("privacy")]
        public Int32 Privacy { get; set; }
    }
}
