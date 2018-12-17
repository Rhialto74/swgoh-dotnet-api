﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using NUnit.Framework;
using SwgohHelpApi;
using SwgohHelpApi.Model;
using Microsoft.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace SwgohHelpApiTests
{
    [TestFixture]
    public class FetchTests
    {
        SwgohHelper helper;
        private const string testUsername = "Rhialto";
        private const string testPassword = "gm1oB4GCigeqyr0kB8G6APqjHk2DvoXXI4rfxXgo";

        [OneTimeSetUp]
        public void SetupTheLogin()
        {
            helper = new SwgohHelper(new UserSettings() { Username = testUsername, Password = testPassword, Debug = "true" });
            helper.Login();
        }

        [Test]
        public void FetchSinglePlayerAndFindTheName()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                language = "eng_us",
                enums = true
            };
            var player = helper.fetchPlayers(options);
            Assert.AreEqual("Rhialto The Marvelous", player[0].Name);
        }

        [Test]
        public void FetchMultiplePlayersAndFindTheName()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726, 362676873 }
            };
            var player = helper.fetchPlayers(options);
            Assert.AreEqual("Rhialto The Marvelous", player[0].Name);
        }

        [Test]
        public void FetchSinglePlayerProjection()
        {
            dynamic obj = new ExpandoObject();
            obj.name = 1;
            obj.allyCode = 1;
                
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                project = obj
            };

            var player = helper.fetchPlayers(options);
            Assert.AreEqual("Rhialto The Marvelous", player[0].Name);
            Assert.IsNull(player[0].Id);
        }

        [Test]
        public void FetchGuildForPlayerAndFindTheName()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 }
            };
            var guild = helper.fetchGuild(options);
            Assert.AreEqual("Perimeter Patrol", guild[0].Name);
        }

        [Test]
        public void FetchUnitsForPlayer()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                language = "eng_us",
                enums = true
            };
            var units = helper.fetchUnits(options);
            TestContext.Write(units);
            //Assert.AreEqual("Perimeter Patrol", guild[0].name);
        }

        [Test]
        public void FetchUnitsForPlayerEnglish()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                language = "eng_us"
            };
            var units = helper.fetchUnits(options);
            TestContext.Write(units);
            //Assert.AreEqual("Perimeter Patrol", guild[0].name);
        }

        [Test]
        public void FetchRosters()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
            };
            var rosters = helper.fetchRosters(options);
            dynamic obj = JArray.Parse(rosters);
            dynamic item = obj[0];
            TestContext.Write(rosters);
            //Assert.AreEqual("Perimeter Patrol", guild[0].name);
        }

        [Test]
        public void FetchSquads()
        {
            var options = new RequestOptions();
            var squads = helper.fetchSquads(options);
            TestContext.Write(squads);
            //Assert.AreEqual("Perimeter Patrol", guild[0].name);
        }

        [Test]
        public void FetchZetas()
        {
            var options = new RequestOptions();
            
            var zetas = helper.fetchZetas(options);
            TestContext.Write(zetas);
            //Assert.AreEqual("Perimeter Patrol", guild[0].name);
        }

        [Test]
        public void FetchSkillData()
        {
            var options = new RequestOptions
            {
                collection = DataEndpointConstants.skillList

            };

            var skillData = JsonConvert.DeserializeObject<List<Skill>>(helper.fetchData(options));
            
            Assert.AreEqual("basicskill_ARC170CLONESERGEANT", skillData[0].id);
        }

        [Test]
        public void FetchUnitsData()
        {
            dynamic match = new ExpandoObject();
            match.rarity = 7;

            dynamic project = new ExpandoObject();
            project.baseId = 7;
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

            var unitsData = JsonConvert.DeserializeObject<List<Unit>>(helper.fetchData(options));
            
            //Assert.AreEqual("basicskill_ARC170CLONESERGEANT", skillData[0].id);
        }

        [Test]
        public void FetchPlayerAndFindNameGeneric()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 }
            };
            
            var player = helper.fetchResults<Player>(options);
            Assert.AreEqual("Rhialto The Marvelous", player[0].Name);
        }

        [Test]
        public void FetchPlayerRawData()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                language = "eng_us",
                enums = true
            };
            var data = helper.fetchPlayersJsonString(options);
            TestContext.Write(data);
        }

        [Test]
        public void FetchGuildForPlayerAndFindTheNameGeneric()
        {
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 }
            };
            var guild = helper.fetchResults<Guild>(options);
            Assert.AreEqual("Perimeter Patrol", guild[0].Name);
        }
    }
}