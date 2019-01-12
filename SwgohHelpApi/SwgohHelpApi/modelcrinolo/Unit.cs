// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Crinolo
{

    public class Unit
    {

        [JsonProperty("updated")]
        public long Updated { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("allyCode")]
        public int AllyCode { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("gp")]
        public int Gp { get; set; }

        [JsonProperty("starLevel")]
        public int StarLevel { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("gearLevel")]
        public int GearLevel { get; set; }

        [JsonProperty("gear")]
        public IList<string> Gear { get; set; }

        [JsonProperty("zetas")]
        public IList<object> Zetas { get; set; }

        [JsonProperty("mods")]
        public IList<Mod> Mods { get; set; }
    }

}
