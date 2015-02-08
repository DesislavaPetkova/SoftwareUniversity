using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKonare
{
    class Loan :Account
    {
        public Loan(Customer customer, decimal balance, decimal interest) :base(customer, balance, interest)
        {

        }

        public override decimal CalculateInterest(decimal money, int months)
        {
            if (this.Customer == Customer.Individual && months < 3)
            {
                return 0;
            }
            if (this.Customer == Customer.Company && months < 2)
            {
                return 0;
            }

            return money * (1 + this.Interest * months);
        }
    }
}
