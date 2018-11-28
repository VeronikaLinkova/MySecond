using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public class Warehouse
    {
        private string name;
        private string adress;
        private string city;
        private string area;
        private string index;
        private List<SalesDepartment> salesDepartments;

        public Warehouse (string name, string adress, string city, string area, string index)
        {
            this.name = name;
            this.adress = adress;
            this.city = city;
            this.area = area;
            this.index = index;
            salesDepartments = new List<SalesDepartment>();
        }
    }
}
