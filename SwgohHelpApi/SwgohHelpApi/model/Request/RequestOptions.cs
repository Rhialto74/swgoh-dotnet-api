using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwgohHelpApi.Model
{
    public class RequestOptions
    {
        public List<int> allycodes { get; set; }
        public string language { get; set; }
        public bool? enums { get; set; }
        public bool? roster { get; set; }
        public bool? units { get; set; }
        public bool? mods { get; set; }
        public object match { get; set; }
        public object project { get; set; }
        public string collection { get; set; }
        public string structure { get; set; }
    }
}
