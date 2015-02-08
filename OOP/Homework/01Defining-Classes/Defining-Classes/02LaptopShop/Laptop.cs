using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
  public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop()
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(
            string model, 
            decimal price, 
            string manufacturer = null, 
            string processor = null, 
            string ram = null, 
            string graphicsCard = null, 
            string hdd = null, 
            string screen = null, 
            Battery battery = null) 
            
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Invalid manufacturer");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Invalid Processor");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Invalid RAM parameter");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Invalid Graphics Card");
                }
                this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Invalid HDD");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentNullException("Invalid screen");
                }
                this.screen = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {

                this.battery = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid Price");
                }
                this.price = value;
            }
        }




        public override string ToString()
        {
            StringBuilder laptopStr = new StringBuilder();
            laptopStr.AppendLine("model: " + this.Model);
            if (this.Manufacturer != null)
            {
                laptopStr.AppendLine("manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                laptopStr.AppendLine("processor: " + this.Processor);
            }
            if (this.Ram != null)
            {
                laptopStr.AppendLine("RAM: " + this.Ram);
            }
            if (this.Hdd != null)
            {
                laptopStr.AppendLine("HDD: " + this.Hdd);
            }
            if (this.Screen != null)
            {
                laptopStr.AppendLine("screen: " + this.Screen);
            }
            if (this.Battery != null)
            {
                laptopStr.Append(this.Battery.ToString());
            }
            laptopStr.AppendLine("price: " + this.Price + " lv.");

            return laptopStr.ToString();
        }

    }

}