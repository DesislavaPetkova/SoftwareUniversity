namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, ITable
    {
       
        private decimal length;
        private decimal width;

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
           
            this.length = length;
            this.width = width;
        }


        public decimal Length
        {
            get
            {
                return this.length;
            }

            set
            {
                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Width * this.Length;
            }
        }

        public override string ToString()
        {
            var output = string.Format(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
            return base.ToString() + output;
        }
    }
}
