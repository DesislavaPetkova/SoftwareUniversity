using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class Computer
    {
        private string name;
        private Component processor;
        private Component graphics;
        private Component motherboard;
        private decimal price;

        public Computer(string name,
            string processorName,
            decimal processorPrice,
            string graphicsName,
            decimal graphicsPrice,
            string motherboardName,
            decimal motherboardPrice,
            string processorDetails = null,
            string graphicsDetails = null,
            string motherboardDetails = null)
        {
            this.Name = name;
            this.Processor = new Component(processorName, processorPrice, processorDetails);
            this.Graphics = new Component(graphicsName, graphicsPrice, graphicsDetails);
            this.Motherboard = new Component(motherboardName, motherboardPrice, motherboardDetails);


        }
        public Computer(string name) : this(name, null, 0, null, 0, null, 0) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name");
                }
                this.name = value;
            }
        }
        public Component Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public Component Graphics
        {
            get { return this.graphics; }
            set { this.graphics = value; }
        }
        public Component Motherboard
        {
            get { return this.motherboard; }
            set { this.motherboard = value; }
        }
        public decimal Price
        {
            get
            {
                price = Processor.Price + Graphics.Price + Motherboard.Price;
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invalid Price");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Name != null)
            {
                result.AppendLine("Computer name: " + this.Name);
            }
            if (this.Processor != null)
            {
                result.AppendLine("Processor: " + Processor.Name);
            }
            if (this.Graphics != null)
            {
                result.AppendLine("Graphic Card: " + Graphics.Name);
            }
            if (this.Motherboard != null)
            {
                result.AppendLine("Motherboard: " + Motherboard.Name);
            }

            if (this.Price > 0)
            {
                result.AppendLine("Totalprice: " + this.Price);
            }
            return result.ToString();
        }

    }
}