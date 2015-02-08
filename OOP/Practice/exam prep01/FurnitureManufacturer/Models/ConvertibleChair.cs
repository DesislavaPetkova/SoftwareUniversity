namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;

        private decimal initialHeight;

        public ConvertibleChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model,  material,  price,  height, numberOfLegs)
        {
            this.initialHeight = height;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
        }

        public void Convert()
        {
            if (IsConverted)
            {
                this.Height = this.initialHeight;
                this.isConverted = false;
            }
            else
            {
                this.Height = 0.10m;
                this.isConverted = true;
            }
        }

        public override string ToString()
        {
            var output =
                string.Format(
                    ", State: {0}",
                    this.IsConverted ? "Converted" : "Normal");
            return base.ToString() + output;
        }
    }
}
