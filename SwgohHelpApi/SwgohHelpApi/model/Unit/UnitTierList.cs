using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwgohHelpApi.Model
{
    [JsonObject("unitTierList")]
    public class UnitTierList
    {
        public int tier { get; set; }
        public List<string> equipmentSetList { get; set; }
        public BaseStat baseStat { get; set; }
    }

}
