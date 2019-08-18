using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwgohHelpApi.Model.Crinolo
{
    public class UnitData
    {
        public Unit unit { get; set; }
    }

    public class UnitDict : Dictionary<string, UnitData>
    {
        
    }
}
