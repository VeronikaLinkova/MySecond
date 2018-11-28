using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public class Edition
    {
        private string name;
        private List<BookType> bookType;
        private decimal price;
        private Publisher publisher;
        private string adress;
        private List<SalesDepartment> salesDepartments;
        private List<Author> authors;               

        public Edition (string name, decimal price, Publisher publisher, string adress)
        {
            this.name = name;
            bookType = new List<BookType>();
            this.price = price;
            this.publisher = publisher;
            this.adress = adress;
            salesDepartments = new List<SalesDepartment>();
            authors = new List<Author>();
        }
    }
}
