using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Interest_Calculator
{

    public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

    class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;
        private CalculateInterest type;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest type)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Type = type;
        }

        public decimal Money 
        {
            get
            {                
                return this.money;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Invalid amount of money");
                }
                this.money = value;            
            }
        }
        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invalid data");
                }
                this.interest = value;
            }
        }
        public int Years
        {
            get
            {
                return this.years;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invalid data");
                }
                this.years = value;
            }
        }
        public CalculateInterest Type
        {
            get
            {
                return this.type;
            }
            set
            {
                
                this.type = value;
            }
        }

        public override string ToString()
        {

            return string.Format("{0:F4}", this.Type(this.Money, this.Interest, this.Years));
        }
    }
}
