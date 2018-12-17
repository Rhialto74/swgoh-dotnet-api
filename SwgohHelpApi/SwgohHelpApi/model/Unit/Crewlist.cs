using System.Collections.Generic;

namespace SwgohHelpApi.Model
{
    public class Crewlist
    {
        public string unitId { get; set; }
        public int slot { get; set; }
        public List<SkillReferenceList> skillReferenceList { get; set; }
    }

}
