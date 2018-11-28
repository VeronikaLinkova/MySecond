using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public class Author
    {
        private string firstName;
        private string secondName;
        private string thirdName;
        private string phoneNumber;
        private string adress;
        private List<Edition> edition;

        public Author (string firstName, string secondName, string thirdName, string phoneNumber, string adress)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.phoneNumber = phoneNumber;
            this.adress = adress;
            edition = new List<Edition>();
        }
    }
}
