using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public class Cash : Payment
    {
        private string adress;
        private string account;

        public Cash (DateTime date, decimal sum, string adress, string account) : base (date, sum)
        {
            this.adress = adress;
            this.account = account;
        }
    }
}
