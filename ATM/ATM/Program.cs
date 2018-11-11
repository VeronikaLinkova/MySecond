using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner Veronika = new Owner();
            CreditAccount crAccount = new CreditAccount(1, Veronika) { Sum = 5000 };
            Veronika.crAccount = crAccount;
            DebitAccount dAccount = new DebitAccount(2, Veronika) { Sum = 10000 };
            Veronika.dAccount = dAccount;
            CurrentAccount cuAccount = new CurrentAccount(3, Veronika) { Sum = 15000 };
            Veronika.cuAccount = cuAccount;
            showState(Veronika);

            TransactionInput TI = new TransactionInput();
            TI.mAccount = dAccount;
            TI.Sum = 100000;
            TI.Execute();
            showState(Veronika);
            TI = null;

            TransactionTransfer<Account> Ttr = new TransactionTransfer<Account>();
            Ttr.mAccount = dAccount;
            Ttr.ToAccount = cuAccount;
            Ttr.Sum = 10000;
            Ttr.Execute();
            showState(Veronika);

            Console.ReadLine();
               
        }

        static void showState(Owner owner)
        {
            Console.WriteLine($"Сумма на дебетовом счете: {owner.dAccount.Sum} ");
            Console.WriteLine($"Сумма на кредитном счете: {owner.crAccount.Sum} ");
            Console.WriteLine($"Сумма на текущем счете: {owner.cuAccount.Sum} ");
        }
    }
}
