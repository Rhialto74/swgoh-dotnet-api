using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using NUnit.Framework;
using SwgohHelpApi;
using SwgohHelpApi.Model.Gg;
using Microsoft.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Net;

namespace SwgohHelpApiTests
{
    [TestFixture]
    class GGTests
    {
        [Test]
        public void DownloadIconsFromSwgohGG()
        {
            var gear = JsonConvert.DeserializeObject<List<Gear>>(SwgohHelper.fetchAllGearFromSwgohGGApi());
            string uri;
            foreach (var item in gear)
            {
                uri = "https://swgoh.gg" + item.Image;
                var imageName = item.BaseId;
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(uri), @"f:\temp-images\" + imageName + ".png");
                }
            }
        }

        public void DownloadAbilityIconsFromSwgohGG()
        {
            var abilities = JsonConvert.DeserializeObject<List<Ability>>(SwgohHelper.fetchAllAbilitiesFromSwgohGGApi());
            string uri;
            foreach (var item in abilities)
            {
                uri = "https://swgoh.gg" + item.Image;
                var imageName = item.BaseId + ".png";
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(uri), @"c:\temp-images\" + imageName);
                }
            }
        }

        [Test]
        public void fetchSpecificGearFromGgAndDeSerializeIt()
        {
            var gear = JsonConvert.DeserializeObject<Gear>(SwgohHelper.fetchSpecificGearFromSwgohGGApi("126"));
            Assert.AreEqual(gear.Cost, 4350);
        }
        
        [Test]
        public void fetchAllAbilitiesFromGgAndDeSerializeThem()
        {
            var abilities = JsonConvert.DeserializeObject<List<Ability>>(SwgohHelper.fetchAllAbilitiesFromSwgohGGApi());
            Assert.AreEqual(abilities[0].CharacterBaseId, "GRIEVOUS");  
        }
    }
}
