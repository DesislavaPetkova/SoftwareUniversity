namespace MusicShop.Models
{
    using System;
    using System.ComponentModel;

    using MusicShopManager.Interfaces;
    using MusicShopManager.Models;

    public class Acoustic : Guitar, IAcousticGuitar
    {
        private bool caseIncluded;
        private StringMaterial stringMaterial;

        public Acoustic(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.NumberOfStrings = 6;
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
            this.IsElectronic = false;
        }

        public bool CaseIncluded
        {
            get
            {
                return this.caseIncluded;
            }

            set
            {
                this.caseIncluded = value;
            }
        }

        public StringMaterial StringMaterial
        {
            get
            {
                return this.stringMaterial;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The material is required.");
                }

                this.stringMaterial = value;
            }
        }

        public override string ToString()
        {
            var output = string.Format("Case included: {0}\n"
                + "String material: {1}", this.CaseIncluded ? "yes" : "no", this.StringMaterial);
            return base.ToString() + output;
        }
    }
}
