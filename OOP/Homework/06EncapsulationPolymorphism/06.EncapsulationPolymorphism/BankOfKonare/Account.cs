using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKonare
{
    abstract class Account :IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interest;

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal Interest { get; set; }

        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }
        
        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(decimal money, int months);
    }
}
