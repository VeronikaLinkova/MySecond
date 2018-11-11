using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
     class Account
    {
        public int ID; // номер счета
        public int Sum;
        public Owner owner;
        public Account(int _id, Owner owner)
        {
            ID = _id;
            this.owner = owner;
        }
}
}
