// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Gg
{

    public class Recipe
    {

        [JsonProperty("base_id")]
        public string BaseId { get; set; }

        [JsonProperty("result_id")]
        public string ResultId { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("ingredients")]
        public IList<Ingredient> Ingredients { get; set; }
    }

}
