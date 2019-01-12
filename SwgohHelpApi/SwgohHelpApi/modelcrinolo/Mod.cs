// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Crinolo
{

    public class Mod
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("set")]
        public int Set { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("pips")]
        public int Pips { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("stat")]
        public IList<IList<double>> Stat { get; set; }
    }

}
