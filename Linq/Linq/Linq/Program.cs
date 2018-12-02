using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {

            ReestrOfOrganization reestr = new ReestrOfOrganization();
            var reestrOfOrganization = reestr.CreateReeast();

            reestr.IncreaseOborotCapital(reestrOfOrganization, true);           
            reestr.IncreaseOborotCapital(reestrOfOrganization, false);            
            reestr.OrganizationWithOkved(reestrOfOrganization, "33333");
            reestr.OrganizationFromOneCity(reestrOfOrganization, "Moscow");

            Console.ReadLine();
        }
    }
}


    

      