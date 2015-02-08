namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;

        private MaterialType material;

        private decimal price;

        private decimal height;

        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material.ToString();
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
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public override string ToString()
        {
            var output =
                string.Format(
                    "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                    this.GetType().Name,
                    this.Model,
                    this.Material,
                    this.Price,
                    this.Height);
            return output;
        }
    }
}
