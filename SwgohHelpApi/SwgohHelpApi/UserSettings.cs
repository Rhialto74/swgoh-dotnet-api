using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SwgohHelpApi
{
    /// <summary>
    /// Defines the various initialization settings for using the API
    /// </summary>
    [Serializable()]
    public class UserSettings
    {
        [JsonProperty("username")]
        public string Username { get; set; } = "";

        [JsonProperty("password")]
        public string Password { get; set; } = "";

        [JsonProperty("client_id")]
        public string ClientId { get; set; } = "123";

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; } = "ABC";

        [JsonProperty("protocol")]
        public string Protocol { get; set; } = "";

        [JsonProperty("host")]
        public string Host { get; set; } = "";

        [JsonProperty("port")]
        public string Port { get; set; } = "";

        [JsonProperty("debug")]
        public string Debug { get; set; } = "false";

    }
}