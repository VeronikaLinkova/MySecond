using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ReestrOfOrganization
    {
        public List<Organization> CreateReeast()
        {
            List<Organization> listOfOrg = new List<Organization>();

            Organization Magnit = new Organization()
            {
                Name = "Magnit",
                INN = "6666",
                Adress = "Saratov",
                Capital = 999,
                OKVED = new List<string>() { "7777", "1111" }
            };

            Organization Gazprom = new Organization()
            {
                Name = "Gazprom",
                INN = "111111",
                Adress = "Moscow",
                Capital = 123,
                OKVED = new List<string>() { "1111", "2222" }
            };

            Organization Rosneft = new Organization()
            {
                Name = "Rosneft",
                INN = "22222",
                Adress = "Moscow",
                Capital = 678,
                OKVED = new List<string>() { "33333", "44444" }
            };

            listOfOrg.Add(Gazprom);
            listOfOrg.Add(Rosneft);
            listOfOrg.Add(Magnit);

            return listOfOrg;
        }

        public void IncreaseOborotCapital(List<Organization> listOfOrg, bool increase = true)
        {
            List<Organization> newList;

            if (increase)
            {
                Console.WriteLine("По возрастанию капитала");
                newList = listOfOrg.OrderBy(x => x.Capital).ToList();
            }
            else
            {
                Console.WriteLine("По убыванию капитала");
                newList = listOfOrg.OrderByDescending(x => x.Capital).ToList();
            }

            foreach (var r in newList)
            {
                Console.WriteLine(r.Name +" "+ r.Capital);
            }
        }

        public void OrganizationFromOneCity(List<Organization> listOfOrg, string city)
        {
            Console.WriteLine($"Вывод организаций из одного города {city}");
            var list = listOfOrg.Where(x => x.Adress.Contains(city)).ToList();

            foreach (var r in list)
            {
                Console.WriteLine(r.Name + " " + r.Adress);
            }
        }

        public void OrganizationWithOkved(List<Organization> listOfOrg, string okved)
        {
            Console.WriteLine($"Вывод организаций с ОКВЕД {okved}");
            var list  = listOfOrg.Where(x => x.OKVED.Contains(okved)).ToList();

            foreach (var r in list)
            {
                Console.WriteLine(r.Name);
            }
        }        
    }
}
