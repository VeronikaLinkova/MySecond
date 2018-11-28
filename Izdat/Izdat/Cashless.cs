using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public class Cashless : Payment
    {
        private string adress;
        private string account;
        private string numberOfCard;

        public Cashless (DateTime date, decimal sum, string adress, string account, string numberOfCard) : base(date, sum)
        {
            this.adress = adress;
            this.account = account;
            this.numberOfCard = numberOfCard;
        }
    }
}
