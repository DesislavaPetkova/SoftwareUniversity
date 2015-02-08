using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKonare
{
    class Deposit :Account
    {
        public Deposit(Customer customer, decimal balance, decimal interest) :base(customer, balance, interest)
        {

        }

        
        public void WithdrawMoney(decimal money)
        {
            Balance -= money;
        }

        public override decimal CalculateInterest(decimal money, int months)
        {
            if (money < 1000)
            {
                return 0;
            }
            return money * (1 + this.Interest * months);
        }
    }
}
