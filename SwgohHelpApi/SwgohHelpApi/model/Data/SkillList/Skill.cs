using System.Collections.Generic;

namespace SwgohHelpApi.Model
{
    public class Skill
    {
        public string id { get; set; }
        public string nameKey { get; set; }
        public string iconKey { get; set; }
        public List<Tier> tierList { get; set; }
        public string abilityReference { get; set; }
        public int skillType { get; set; }
        public bool isZeta { get; set; }
        public long updated { get; set; }
    }


}
