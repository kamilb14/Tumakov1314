using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov1314
{
    public class DeveloperInfoAttribute : System.Attribute
    {
        public string Date { get; set; }
        public string Developer { get; private set; }
        public DeveloperInfoAttribute(string developer, string date)
        {
            this.Developer = developer;
            Date = date;
        }
    }
}
