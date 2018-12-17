// This is a generated file. Override or extend, but do not modify it directly

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwgohHelpApi.Model
{

    public class Equipped
    {

        [JsonProperty("equipmentId")]
        public string EquipmentId { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("nameKey")]
        public string NameKey { get; set; }
    }

}
