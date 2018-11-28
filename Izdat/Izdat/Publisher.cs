using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public enum Country
    {
        Russia,
        USA,
        Canada,
        Argentina
    }

    public class Publisher
    {
        private string name;
        private string city;
        private Country country;
        private List<Edition> edition;
        private string adress;

        public Publisher (string name, string city, Country country, string adress)
        {
            this.name = name;
            this.city = city;
            this.country = country;
            edition = new List<Edition>();
            this.adress = adress;
        }
    }
}
