using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwgohHelpApi.Model.Crinolo;

namespace SwgohHelpApi.Model
{
    public class PlayerInformation
    {
        public List<string> PlayerNames { get; set; }
        public List<UnitData> UnitStatList { get; set; }
        public List<Roster> RosterList { get; set; }
        public List<UnitTierList> UnitInfo { get; set; }
    }
}
