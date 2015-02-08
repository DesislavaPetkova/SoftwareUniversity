using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKonare
{
    class Mortgage :Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {

        }
        public override decimal CalculateInterest(decimal money, int months)
        {
            decimal interest = money * (1 + this.Interest * months);
            if (months < 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months < 12 && this.Customer == Customer.Company)
            {
                return interest / 2;
            }
            return interest;
        }
    }
}
