using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Transaction<T> where T:Account
    {
        public T mAccount; //с какого счета перевод
        
        public int Sum; //сумма перевода

        public bool CheckDebt()
        {
            return (mAccount.owner.crAccount.Sum < -20000);
        }

        public virtual void Execute()
        {
            
        }
    }
}
