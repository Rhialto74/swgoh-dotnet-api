// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class GuildRoster
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("guildMemberLevel")]
        public string GuildMemberLevel { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("allyCode")]
        public int AllyCode { get; set; }

        [JsonProperty("gp")]
        public int Gp { get; set; }

        [JsonProperty("gpChar")]
        public int GpChar { get; set; }

        [JsonProperty("gpShip")]
        public int GpShip { get; set; }

        [JsonProperty("updated")]
        public object Updated { get; set; }
    }

}
