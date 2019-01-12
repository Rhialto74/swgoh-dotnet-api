// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Crinolo
{

    public class Mods
    {

        [JsonProperty("Physical Damage")]
        public int PhysicalDamage { get; set; }

        [JsonProperty("Special Damage")]
        public int SpecialDamage { get; set; }

        [JsonProperty("Armor")]
        public double Armor { get; set; }

        [JsonProperty("Resistance")]
        public double Resistance { get; set; }

        [JsonProperty("Protection")]
        public int Protection { get; set; }

        [JsonProperty("None")]
        public int None { get; set; }

        [JsonProperty("Health")]
        public int Health { get; set; }

        [JsonProperty("Physical Critical Chance")]
        public double PhysicalCriticalChance { get; set; }

        [JsonProperty("Special Critical Chance")]
        public double SpecialCriticalChance { get; set; }
    }

}
