namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    public abstract class Guitar : Instrument, IGuitar
    {
        private string bodyWood;

        private string fingerboardWood;

        private int numberOfStrings;

        public Guitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
            : base(make, model, price, color)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
            this.NumberOfStrings = numberOfStrings;
        }

        public string BodyWood
        {
            get
            {
                return this.bodyWood;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Field cannot be null or empty");
                }

                this.bodyWood = value;
            }
        }

        public string FingerboardWood
        {
            get
            {
                return this.fingerboardWood;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Field cannot be null or empty");
                }

                this.fingerboardWood = value;
            }
        }

        public int NumberOfStrings
        {
            get
            {
                return this.numberOfStrings;
            }

            set
            {
                this.numberOfStrings = value;
            }
        }

        public override string ToString()
        {
            var output = string.Format("= {0} {1} =\n"
                + "Price: ${2:0.00}\n"
                + "Color: {3}\n"
                + "Electronic: {4}\n"
                + "Strings: {5}\n"
                + "Body wood: {6}\n"
                + "Fingerboard wood: {7}\n", this.Make, this.Model, this.Price, this.Color, this.IsElectronic ? "yes" : "no", this.NumberOfStrings, this.BodyWood, this.FingerboardWood);
            return output;
        }
    }
}
