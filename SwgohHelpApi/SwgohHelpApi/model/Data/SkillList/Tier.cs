using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwgohHelpApi.Model
{
    public class Tier
    {
        public string recipeId { get; set; }
        public int requiredUnitLevel { get; set; }
        public int requiredUnitRarity { get; set; }
        public int requiredUnitTier { get; set; }
        public string powerOverrideTag { get; set; }
    }
}
