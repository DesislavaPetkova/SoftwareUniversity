namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    public class Drums : Instrument, IDrums
    {
        private int width;

        private int height;

        public Drums(string make, string model, decimal price, string color, int width, int height)
            : base(make, model, price, color)
        {
            this.Width = width;
            this.Height = height;
            this.IsElectronic = false;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be positive");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be positive");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            var output = string.Format("= {0} {1} =\n"
                + "Price: ${2}\n"
                + "Color: {3}\n"
                + "Electronic: {4}\n"
                + "Size: {5}cm x {6}cm", this.Make, this.Model, this.Price, this.Color, this.IsElectronic ? "yes" : "no", this.Width, this.Height);
            return output;
        }
    }
}
