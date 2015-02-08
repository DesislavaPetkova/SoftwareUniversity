using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Payment
    {
        private string product;
        private decimal price;

        public string Product { get; set; }
        public decimal Price { get; set; }

        public Payment(string product, decimal price)
        {
            this.Product = product;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} -- {1}", this.Product, this.Price);
        }
    }
}
