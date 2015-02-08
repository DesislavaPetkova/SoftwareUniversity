using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKonare
{
    class TestMain
    {
        static void Main(string[] args)
        {
            Deposit depo = new Deposit(Customer.Individual, 12112m, 3.4m);
            Console.WriteLine(depo.Balance);
            depo.DepositMoney(100m);
            Console.WriteLine(depo.Balance);
            depo.WithdrawMoney(1000m);
            Console.WriteLine(depo.Balance);
        }
    }
}
