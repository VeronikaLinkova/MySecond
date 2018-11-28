using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{  
    public class SalesDepartment
    {
        private string dataSales;
        private int count;
        private decimal sumOfSales;        

        private List<Payment> payment;

        public SalesDepartment (string dataSales, int count, decimal sumOfSales)
        {
            this.dataSales = dataSales;
            this.count = count;
            this.sumOfSales = sumOfSales;            
            payment = new List<Payment>();
        }
    }
}
