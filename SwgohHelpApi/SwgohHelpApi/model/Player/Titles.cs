// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class Titles
    {

        [JsonProperty("selected")]
        public string Selected { get; set; }

        [JsonProperty("unlocked")]
        public IList<string> Unlocked { get; set; }
    }

}
