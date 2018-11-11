using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class TransactionTransfer<T> : Transaction<Account> where T : Account
    {

        public T ToAccount; //на какой счет перевод
        public override void Execute()
        {
            if (CheckDebt())
            {
                return;
            }
            if (mAccount.Sum > Sum)
            {
                mAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет {mAccount.ID}: {mAccount.Sum}$ \nСчет {ToAccount.ID}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {mAccount.ID} ");
            }
        }
    }
}
