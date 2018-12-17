// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class Char
    {

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("squad")]
        public IList<Squad> Squad { get; set; }
    }

}
