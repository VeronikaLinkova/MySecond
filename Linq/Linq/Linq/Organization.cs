using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Organization
    {
        public Organization()
        {

        }

        public string Name { get; set; }
        public string INN { get; set; }

        public List<string> OKVED { get; set; } //???

        public string Adress { get; set; }

        public decimal Capital { get; set; }
    }
}
