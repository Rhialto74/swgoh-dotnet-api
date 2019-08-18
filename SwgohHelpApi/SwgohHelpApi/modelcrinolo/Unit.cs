// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Crinolo
{

    public class UnitWithStat
    {

        [JsonProperty("defId")]
        public string DefId { get; set; }

        [JsonProperty("nameKey")]
        public string NameKey { get; set; }

        [JsonProperty("rarity")]
        public int Rarity { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("gear")]
        public int Gear { get; set; }

        [JsonProperty("equipped")]
        public IList<Equipped> Equipped { get; set; }

        [JsonProperty("combatType")]
        public int CombatType { get; set; }

        [JsonProperty("skills")]
        public IList<Skill> Skills { get; set; }

        [JsonProperty("mods")]
        public IList<Mod> Mods { get; set; }

        [JsonProperty("gp")]
        public int Gp { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }

}
