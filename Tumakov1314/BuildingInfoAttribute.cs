using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov1314
{
    public class BuildingInfoAttribute : System.Attribute
    {
        public string name { get; set; }
        public string organization { get; set; }
        public BuildingInfoAttribute()
        {

        }
        public BuildingInfoAttribute(string Name, string Organization)
        {
            this.name = Name;
            this.organization = Organization;
        }
    }
}
