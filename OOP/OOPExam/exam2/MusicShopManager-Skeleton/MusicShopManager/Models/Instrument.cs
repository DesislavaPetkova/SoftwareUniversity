namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    public abstract class Instrument : Article, IInstrument
    {
        private string color;

        private bool isElectronic;

        protected Instrument(string make, string model, decimal price, string color)
            : base(make, model, price)
        {
            this.Color = color;
            this.IsElectronic = isElectronic;
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Field cannot be null or empty");
                }

                this.color = value;
            }
        }

        public bool IsElectronic
        {
            get
            {
                return this.isElectronic;
            }

            set
            {
                this.isElectronic = value;
            }
        }
        
    }
}
