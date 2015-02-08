using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
   public class Battery
    {
        private string type;
        private float batteryLife;

        public string Type
        {
            get { return this.type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid battery name");
                }
                this.type = value;
            }

        }
        public float BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid battery life value");
                }
                this.batteryLife = value;
            }

        }
        public Battery(string type)
            : this(type, 0)
        {
            this.Type = type;
        }
        public Battery(string type, float batteryLife)
            
        {
            this.Type = type;
            this.BatteryLife = batteryLife;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Type != null)
            {
                result.AppendLine("battery: " + this.Type);
            }
            if (this.BatteryLife > 0)
            {
                result.AppendLine("battery life: " + this.BatteryLife + "hours");
            }
            return result.ToString();
        }
    }
}
