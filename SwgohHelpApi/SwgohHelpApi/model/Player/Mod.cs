// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class Mod
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("set")]
        public int Set { get; set; }

        [JsonProperty("pips")]
        public int Pips { get; set; }

        [JsonProperty("primaryStat")]
        public PrimaryStat PrimaryStat { get; set; }

        [JsonProperty("secondaryStat")]
        public IList<SecondaryStat> SecondaryStat { get; set; }
    }

}
