namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
       
        private int numberOfLegs;

        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs) 
            : base(model, materialType, price, height)
        {
            
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }

            set
            {
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            var output = string.Format(", Legs: {0}", this.NumberOfLegs);
            return base.ToString() + output;
        }
    }
}
