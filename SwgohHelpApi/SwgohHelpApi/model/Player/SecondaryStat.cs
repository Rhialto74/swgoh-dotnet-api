// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class SecondaryStat
    {

        [JsonProperty("unitStat")]
        public string UnitStat { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("roll")]
        public int Roll { get; set; }
    }

}
