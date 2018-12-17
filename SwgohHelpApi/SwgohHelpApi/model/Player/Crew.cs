// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class Crew
    {

        [JsonProperty("unitId")]
        public string UnitId { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("skillReferenceList")]
        public IList<SkillReferenceList> SkillReferenceList { get; set; }

        [JsonProperty("gp")]
        public int Gp { get; set; }

        [JsonProperty("cp")]
        public int Cp { get; set; }
    }

}
