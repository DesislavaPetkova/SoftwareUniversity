namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    public abstract class Article : IArticle
    {
        private string make;

        private string model;

        private decimal price;

        public Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public string Make
        {
            get
            {
                return this.make;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Field cannot be null or empty");
                }

                this.make = value;
            }
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
                    throw new ArgumentException("Field cannot be null or empty");
                }
                this.model = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }

                this.price = value;
            }
        }


    }
}
