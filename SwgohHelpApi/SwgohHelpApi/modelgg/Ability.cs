using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwgohHelpApi.Model.Gg
{
    public class Ability
    {
        [JsonProperty("base_id")]
        public string BaseId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("tier_max")]
        public int TierMax { get; set; }

        [JsonProperty("is_zeta")]
        public bool IsZeta { get; set; }

        [JsonProperty("is_omega")]
        public bool IsOmega { get; set; }

        [JsonProperty("combat_type")]
        public int CombatType { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("character_base_id")]
        public string CharacterBaseId { get; set; }
    }
}
