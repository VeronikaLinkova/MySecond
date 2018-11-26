using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class TransactionOutput: Transaction<Account>
    {

        public override void Execute()
        {
            if (CheckDebt())
            {
                return;
            }
            if (Sum > 30000)
            {
                Console.WriteLine("Запрещено снятие более чем 30000 за сеанс");
                return;
            }
            else
            {
                if (mAccount.Sum >= Sum)
                {
                    mAccount.Sum -= Sum;
                    Console.WriteLine("Деньги выданы");
                }

                else
                {
                    Console.WriteLine($"Недостаточно денег на счете {mAccount.ID} ");
                }

                    
            }
        }
    }
}
