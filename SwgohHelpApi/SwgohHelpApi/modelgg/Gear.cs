// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model.Gg
{

    public class Gear
    {

        [JsonProperty("base_id")]
        public string BaseId { get; set; }

        [JsonProperty("recipes")]
        public IList<Recipe> Recipes { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("required_level")]
        public int RequiredLevel { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string,double> Stats { get; set; }

        [JsonProperty("mark")]
        public string Mark { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ingredients")]
        public IList<Ingredient2> Ingredients { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
