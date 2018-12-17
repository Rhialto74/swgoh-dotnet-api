// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class SkillReferenceList
    {

        [JsonProperty("skillId")]
        public string SkillId { get; set; }

        [JsonProperty("requiredTier")]
        public int RequiredTier { get; set; }

        [JsonProperty("requiredRarity")]
        public int RequiredRarity { get; set; }
    }

}
