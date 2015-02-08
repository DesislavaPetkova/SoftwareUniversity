using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKonare
{
    interface IAccount
    {
        void DepositMoney(decimal money);

        decimal CalculateInterest(decimal money, int months);
    }
}
