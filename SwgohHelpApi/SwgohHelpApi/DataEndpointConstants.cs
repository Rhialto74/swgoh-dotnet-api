using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwgohHelpApi
{
    public static class DataEndpointConstants
    {
        public const string abilityList = "abilityList";
        public const string battleEnvironmentsList = "battleEnvironmentsList";
        public const string battleTargetingRuleList = "battleTargetingRuleList";
        public const string categoryList = "categoryList";
        public const string challengeList = "challengeList";
        public const string challengeStyleList = "challengeStyleList";
        public const string effectList = "effectList";
        public const string environmentCollectionList = "environmentCollectionList";
        public const string equipmentList = "equipmentList";
        public const string eventSamplingList = "eventSamplingList";
        public const string guildExchangeItemList = "guildExchangeItemList";
        public const string guildRaidList = "guildRaidList";
        public const string helpEntryList = "helpEntryList";
        public const string materialList = "materialList";
        public const string playerTitleList = "playerTitleList";
        public const string powerUpBundleList = "powerUpBundleList";
        public const string raidConfigList = "raidConfigList";
        public const string recipeList = "recipeList";
        public const string requirementList = "requirementList";
        public const string skillList = "skillList";
        public const string starterGuildList = "starterGuildList";
        public const string statModList = "statModList";
        public const string statModSetList = "statModSetList";
        public const string statProgressionList = "statProgressionList";
        public const string tableList = "tableList";
        public const string targetingSetList = "targetingSetList";
        public const string territoryBattleDefinitionList = "territoryBattleDefinitionList";
        public const string territoryWarDefinitionList = "territoryWarDefinitionList";
        public const string unitsList = "unitsList";
        public const string unlockAnnouncementDefinitionList = "unlockAnnouncementDefinitionList";
        public const string warDefinitionList = "warDefinitionList";
        public const string xpTableList = "xpTableList";

        public static List<string> AllDataFields()
        {
            return new List<string>()
            {
                "abilityList",
                "battleEnvironmentsList",
                "battleTargetingRuleList",
                "categoryList",
                "challengeList",
                "challengeStyleList",
                "effectList",
                "environmentCollectionList",
                "equipmentList",
                "eventSamplingList",
                "guildExchangeItemList",
                "guildRaidList",
                "helpEntryList",
                "materialList",
                "playerTitleList",
                "powerUpBundleList",
                "raidConfigList",
                "recipeList",
                "requirementList",
                "skillList",
                "starterGuildList",
                "statModList",
                "statModSetList",
                "statProgressionList",
                "tableList",
                "targetingSetList",
                "territoryBattleDefinitionList",
                "territoryWarDefinitionList",
                "unitsList",
                "unlockAnnouncementDefinitionList",
                "warDefinitionList",
                "xpTableList"
            };

        }
    }
}