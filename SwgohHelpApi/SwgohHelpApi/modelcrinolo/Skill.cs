﻿// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Crinolo
{

    public class Skill
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("nameKey")]
        public string NameKey { get; set; }

        [JsonProperty("isZeta")]
        public bool IsZeta { get; set; }

        [JsonProperty("tiers")]
        public int Tiers { get; set; }
    }

}
