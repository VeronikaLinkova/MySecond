using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class CurrentAccount: Account
    {
        public CurrentAccount(int _id, Owner owner) : base(_id, owner)
        {

        }
    }
}
