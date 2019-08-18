using System;
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
using SwgohHelpApi.Model.Crinolo;
using Unit = SwgohHelpApi.Model.Unit;

namespace SwgohHelpApi
{
    public class SwgohHelper
    {
        private UriPathBuilder ServiceUri;
        public static string Token { get; set; }
        private string User { get; set; }
        
        public SwgohHelper()
        {

        }

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
            catch
            {
                throw;
            }

        }

        public async Task<HttpResponseMessage> LoginAsync()
        {
            try
            {
                return await ServiceUri.SignIn.WithHeaders(new { Content_Type = "application/x-www-form-urlencoded" }).PostUrlEncodedAsync(User);
            }
            catch
            {
                throw;
            }

        }

        public void LoginAsync(HttpResponseMessage cachedResponse)
        {
            var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(cachedResponse.Content.ReadAsStringAsync().Result);
            Token = "Bearer " + loginResponse.AccessToken + "";
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
            catch
            {
                throw;
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
            catch
            {
                throw;
            }
        }

        private async Task<string> fetchApiAsync(string url, object param)
        {
            try
            {
                var response = url.WithHeaders(new { Content_Type = "application/json", Authorization = Token }).PostJsonAsync(param).Result;
                return await response.Content.ReadAsStringAsync();
            }
            catch
            {
                throw;
            }
        }

        public static string fetchAllGearFromSwgohGGApi()
        {
            string ggurl = "https://swgoh.gg/api/gear/";
            
            try
            {
                var response = (ggurl).GetAsync().Result;
                return response.Content.ReadAsStringAsync().Result;
            }
            catch
            {
                throw;
            }
        }

        public static string fetchAllAbilitiesFromSwgohGGApi()
        {
            string ggurl = "https://swgoh.gg/api/abilities/";

            try
            {
                var response = (ggurl).GetAsync().Result;
                return response.Content.ReadAsStringAsync().Result;
            }
            catch
            {
                throw;
            }
        }

        public static string fetchSpecificGearFromSwgohGGApi(string code)
        {
            string ggurl = "https://swgoh.gg/api/gear/" + code + "/";
            
            try
            {
                var response = (ggurl).GetAsync().Result;
                return response.Content.ReadAsStringAsync().Result;

            }
            catch
            {
                throw;
            }
        }

        public static string fetchSpecificAbilityFromSwgohGGApi(string baseId)
        {
            string ggurl = "https://swgoh.gg/api/abilities/" + baseId + "/";

            try
            {
                var response = (ggurl).GetAsync().Result;
                return response.Content.ReadAsStringAsync().Result;
            }
            catch
            {
                throw;
            }
        }

        public static string fetchAllUnitsForPlayerFromCrinolo(string code)
        {
            string crinUrl = "https://crinolo-swgoh.glitch.me/statCalc/api/player/" + code + "/characters?flags=withModCalc,gameStyle";

            try
            {
                var response = (crinUrl).GetAsync().Result;
                return response.Content.ReadAsStringAsync().Result;

            }
            catch
            {
                throw;
            }
        }

        public static List<UnitWithStat> fetchListOfUnitsForPlayerFromCrinolo(string code)
        {
            string crinUrl = "https://crinolo-swgoh.glitch.me/statCalc/api/player/" + code + "/characters?flags=withModCalc,gameStyle";

            try
            {
                var response = (crinUrl).GetAsync().Result;
                return JsonConvert.DeserializeObject<List<UnitWithStat>>(response.Content.ReadAsStringAsync().Result);
            }
            catch
            {
                throw;
            }
        }

        public string fetchPlayersJsonString(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Player, options);

            return response;
        }

        public async Task<string> fetchPlayersJsonStringAsync(RequestOptions options)
        {
            return await fetchApiAsync(ServiceUri.Player, options);
        }

        public string fetchGuildJsonString(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Guild, options);

            return response;
        }

        public string fetchUnitJsonString(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Units, options);

            return response;
        }

        public string fetchLocalizedUnitJsonString(RequestOptions options)
        {
            return fetchApi(ServiceUri.Data, options);
        }

        public List<Player> fetchPlayers(RequestOptions options)
        {
            var response = fetchPlayersJsonString(options);

            return JsonConvert.DeserializeObject<List<Player>>(response);
        }

        public async Task<string> fetchPlayersAsync(RequestOptions options)
        {
            return await fetchPlayersJsonStringAsync(options);
        }

        public List<Unit> FetchGearTiersForUnits(string baseid)
        {
            dynamic match = new ExpandoObject();
            match.rarity = 7;
            match.baseId = baseid;


            dynamic project = new ExpandoObject();
            project.unitTierList = new ExpandoObject() as dynamic;
            project.unitTierList.tier = 1;
            project.unitTierList.equipmentSetList = 1;


            var options = new RequestOptions
            {
                collection = DataEndpointConstants.unitsList,
                language = "eng_us",
                enums = true,
                match = match,
                project = project
            };
            
            return JsonConvert.DeserializeObject<List<Unit>>(this.fetchData(options));
        }

        public List<LocalizedUnit> FetchLocalizedUnits()
        {
            dynamic match = new ExpandoObject();
            match.rarity = 7;

            dynamic project = new ExpandoObject();
            project.baseId = 1;
            project.nameKey = 1;
            project.descKey = 1;
            project.forceAlignment = 1;
            project.categoryIdList = 1;
            project.combatType = 1;

            var options = new RequestOptions
            {
                collection = DataEndpointConstants.unitsList,
                language = "eng_us",
                enums = true,
                match = match,
                project = project
            };
            var response = fetchLocalizedUnitJsonString(options);

            return JsonConvert.DeserializeObject<List<LocalizedUnit>>(response);
        }

        public string FetchZetasJsonString(RequestOptions options)
        {
            var response = this.fetchApi(ServiceUri.Zetas, options);

            return response;
        }

        public string FetchSquadsJsonString(RequestOptions options)
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
            var response = fetchUnitJsonString(options);

            return response;

        }

        public List<Guild> fetchGuild(RequestOptions options)
        {
            var response = fetchGuildJsonString(options);

            return JsonConvert.DeserializeObject<List<Guild>>(response);
        }
        
    }

}