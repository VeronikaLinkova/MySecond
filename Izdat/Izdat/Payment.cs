using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public class Payment
    {
        private DateTime date;
        private decimal sum;

        public Payment (DateTime date, decimal sum)
        {
            this.date = date;
            this.sum = sum;
        }
    }
}
