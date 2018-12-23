// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class LocalizedUnit
    {

        [JsonProperty("nameKey")]
        public string NameKey { get; set; }

        [JsonProperty("forceAlignment")]
        public string ForceAlignment { get; set; }

        [JsonProperty("combatType")]
        public string CombatType { get; set; }

        [JsonProperty("descKey")]
        public string DescKey { get; set; }

        [JsonProperty("baseId")]
        public string BaseId { get; set; }

        [JsonProperty("categoryIdList")]
        public IList<string> CategoryIdList { get; set; }
    }

}
