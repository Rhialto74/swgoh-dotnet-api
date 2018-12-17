using System.Collections.Generic;

namespace SwgohHelpApi.Model
{
    public class Unit
    {
        public string id { get; set; }
        public string unitPrefab { get; set; }
        public string thumbnailName { get; set; }
        public string nameKey { get; set; }
        public int rarity { get; set; }
        public int maxRarity { get; set; }
        public int forceAlignment { get; set; }
        public string xpTableId { get; set; }
        public int actionCountMin { get; set; }
        public int actionCountMax { get; set; }
        public int combatType { get; set; }
        public string descKey { get; set; }
        public int threatLevel { get; set; }
        public bool obtainable { get; set; }
        public string baseId { get; set; }
        public string promotionRecipeReference { get; set; }
        public string statProgressionId { get; set; }
        public List<string> categoryIdList { get; set; }
        public int trainingXpWorthBaseValueOverride { get; set; }
        public int maxLevelOverride { get; set; }
        public int trainingCostMultiplierOverride { get; set; }
        public string creationRecipeReference { get; set; }
        public List<SkillReferenceList> skillReferenceList { get; set; }
        public int basePower { get; set; }
        public BaseStat baseStat { get; set; }
        public string primaryStat { get; set; }
        public List<UnitTierList> unitTierList { get; set; }
        public object basicAttack { get; set; }
        public object leaderAbility { get; set; }
        public object[] limitBreakList { get; set; }
        public object[] uniqueAbilityList { get; set; }
        public object[] crewAbilityList { get; set; }
        public object[] crewUniqueAbilityList { get; set; }
        public BasicAttackRef basicAttackRef { get; set; }
        public LeaderAbilityRef leaderAbilityRef { get; set; }
        public LimitBreakRefList[] limitBreakRefList { get; set; }
        public UniqueAbilityRefList[] uniqueAbilityRefList { get; set; }
        public object[] crewAbilityRefList { get; set; }
        public object[] crewUniqueAbilityRefList { get; set; }
        public int primaryUnitStat { get; set; }
        public long obtainableTime { get; set; }
        public Crewlist[] crewList { get; set; }
        public int commandCost { get; set; }
        public string crewContributionTableId { get; set; }
        public int unitClass { get; set; }
        public string battlePortraitPrefab { get; set; }
        public string battlePortraitNameKey { get; set; }
        public long updated { get; set; }
    }

}
