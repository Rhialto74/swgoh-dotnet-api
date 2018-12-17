﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Flurl.Http;
using Flurl.Http.Configuration;
using SwgohHelpApi.Model;


namespace SwgohHelpApi
{
    public class SwgohHelper
    {
        private UriPathBuilder ServiceUri;
        public static string Token { get; set; }
        private string User { get; set; }
        
        public SwgohHelper(UserSettings settings)
        {

            User = "username=" + settings.Username;
            User += "&password=" + settings.Password;
            User += "&grant_type=password";
            User += "&client_id=" + settings.ClientId;
            User += "&client_secret=" + settings.ClientSecret;

            Token = null;
            ServiceUri = new UriPathBuilder(string.IsNullOrEmpty(settings.Protocol) ? "https" : settings.Protocol,
                        string.IsNullOrEmpty(settings.Host) ? "api.swgoh.help" : settings.Host, string.IsNullOrEmpty(settings.Port) ? -1 : int.Parse(settings.Port));

            FlurlHttp.Configure(c =>
            {
                c.JsonSerializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            });
        }

        public void Login()
        {
            try
            {
                var response = ServiceUri.SignIn.WithHeaders(new { Content_Type = "application/x-www-form-urlencoded" }).PostUrlEncodedAsync(User).Result;
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(response.Content.ReadAsStringAsync().Result);
                Token = "Bearer " + loginResponse.AccessToken + "";
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private string GetUriToUse(Type type)
        {
            switch(type.Name)
            {
                case "Player":
                    return ServiceUri.Player;
                case "Guild":
                    return ServiceUri.Guild;
            }
            return "";
        }
        public List<T> fetchResults<T>(RequestOptions options)
        {
            try
            {
                string uri = GetUriToUse(typeof(T));
                if (uri == "")
                    throw new Exception("Invalid Type Used in Fetch Results. Type: " + typeof(T).Name);

                var response = uri.WithHeaders(new { Content_Type = "application/json", Authorization = Token }).PostJsonAsync(options).Result;
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Makes actual API calls to the service.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private string fetchApi(string url, object param)
        {
            try
            {
                
                var response = url.WithHeaders(new { Content_Type = "application/json", Authorization = Token }).PostJsonAsync(param).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string fetchPlayersJsonString(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Player, options);

            return response;
        }

        public string fetchGuildJsonString(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Guild, options);

            return response;
        }

        public List<Player> fetchPlayers(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Player, options);

            return JsonConvert.DeserializeObject<List<Player>>(response);
        }

        public string fetchZetas(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Zetas, options);

            return response;
        }

        public string fetchSquads(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Squads, options);

            return response;
        }

        public string fetchRosters(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Roster, options);

            return response;
        }

        public string fetchEvents(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Events, options);

            return response;

        }

        public string fetchBattles(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Battles, options);

            return response;
        }

        public string fetchData(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Data, options);

            return response;

        }

        public string fetchUnits(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Units, options);

            return response;

        }

        public List<Guild> fetchGuild(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Guild, options);

            return JsonConvert.DeserializeObject<List<Guild>>(response);
        }
        
    }

}