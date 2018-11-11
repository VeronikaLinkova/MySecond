using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class TransactionInput : Transaction<Account>
    {
        public override void Execute()
        {
            if (CheckDebt())
            {
                return;
            }

            if(mAccount == mAccount.owner.cuAccount && Sum >= 1000000) 
            {
                mAccount.owner.dAccount.Sum += 2000;
            }

            mAccount.Sum += Sum;
        }

    }
}
