using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;     

        public Component(string name, decimal price) : this(name, price, null) { }
        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("invalid component name");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("invalid component price");
                }
                this.price = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Invalid component");
                }
                this.details = value;
            }
        }
        public override string ToString()
        {
            string componentStr = String.Format("{0}, price: {1} lv", this.Name, this.Price);
            if (!String.IsNullOrEmpty(this.Details))
            {
                componentStr += ", details: " + this.Details;
            }
            return componentStr;
        }

    }
}
