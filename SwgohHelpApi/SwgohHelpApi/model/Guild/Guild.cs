// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class Guild
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("required")]
        public int Required { get; set; }

        [JsonProperty("bannerColor")]
        public string BannerColor { get; set; }

        [JsonProperty("bannerLogo")]
        public string BannerLogo { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("gp")]
        public int Gp { get; set; }

        [JsonProperty("raid")]
        public Raid Raid { get; set; }

        [JsonProperty("roster")]
        public IList<GuildRoster> Roster { get; set; }

        [JsonProperty("updated")]
        public long Updated { get; set; }
    }

}
