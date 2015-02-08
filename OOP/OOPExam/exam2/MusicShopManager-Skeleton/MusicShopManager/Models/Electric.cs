namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    public class Electric : Guitar, IElectricGuitar
    {
        private int numberOfAdapters;

        private int numberOfFrets;

        public Electric(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.NumberOfStrings = 6;
            this.numberOfAdapters = numberOfAdapters;
            this.numberOfFrets = numberOfFrets;
            this.IsElectronic = true;
        }

        public int NumberOfAdapters
        {
            get
            {
                return this.numberOfAdapters;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Adapters should be non-negative number");
                }

                this.numberOfAdapters = value;
            }
        }

        public int NumberOfFrets
        {
            get
            {
                return this.numberOfFrets;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Frets should be positive number");    
                }

                this.numberOfFrets = value;
            }
        }

        public override string ToString()
        {
            var output = string.Format("Adapters: {0}\n"
                + "Frets: {1}", this.NumberOfAdapters, this.numberOfFrets);
            return base.ToString() + output;
        }
    }
}
