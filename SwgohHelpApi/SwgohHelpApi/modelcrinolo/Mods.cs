﻿// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Crinolo
{

    public class Mods
    {

        [JsonProperty("Health")]
        public int Health { get; set; }

        [JsonProperty("Protection")]
        public int Protection { get; set; }

        [JsonProperty("Speed")]
        public int Speed { get; set; }

        [JsonProperty("Critical Damage")]
        public double CriticalDamage { get; set; }

        [JsonProperty("Potency")]
        public double Potency { get; set; }

        [JsonProperty("Tenacity")]
        public double Tenacity { get; set; }

        [JsonProperty("Health Steal")]
        public double HealthSteal { get; set; }

        [JsonProperty("Defense Penetration")]
        public double DefensePenetration { get; set; }

        [JsonProperty("Physical Damage")]
        public int PhysicalDamage { get; set; }

        [JsonProperty("Physical Critical Chance")]
        public double PhysicalCriticalChance { get; set; }

        [JsonProperty("Armor Penetration")]
        public int ArmorPenetration { get; set; }

        [JsonProperty("Accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("Armor")]
        public double Armor { get; set; }

        [JsonProperty("Dodge Chance")]
        public double DodgeChance { get; set; }

        [JsonProperty("Critical Avoidance")]
        public double CriticalAvoidance { get; set; }

        [JsonProperty("Special Damage")]
        public int SpecialDamage { get; set; }

        [JsonProperty("Special Critical Chance")]
        public double SpecialCriticalChance { get; set; }

        [JsonProperty("Resistance Penetration")]
        public double ResistancePenetration { get; set; }

        [JsonProperty("Resistance")]
        public double Resistance { get; set; }
    }

}
