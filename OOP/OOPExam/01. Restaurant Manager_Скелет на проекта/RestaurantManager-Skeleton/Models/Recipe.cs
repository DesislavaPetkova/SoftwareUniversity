using System.ComponentModel;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public abstract class Recipe : IRecipe
    {
        protected string name;
        protected decimal price;
        protected int calories;
        protected int quantityPerServing;
        protected MetricUnit unit;
        protected int timeToPrepare;


        public Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.Unit = unit;
            this.TimeToPrepare = timeToPrepare;
        }


        public string Name
        {
            
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid Name");
                }
                this.name = value; 
                
            }
        }

        public decimal Price
        {
            
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
                
            }
        }

        public virtual int Calories
        {
            
            get { return this.calories; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Calories cannot be negative");
                }
                
                this.calories = value; 
                
            }
        }

        public int QuantityPerServing
        {
            
            get { return this.quantityPerServing; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("QuantityPerServing cannot be negative");
                }
                this.quantityPerServing = value; 
                
            }
        }

        public MetricUnit Unit
        {
            
            get { return unit; }
            set { this.unit = value; }
        }

        public virtual int TimeToPrepare
        {
            
            get { return this.timeToPrepare; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("TimeToPrepare cannot be negative");
                }
                this.timeToPrepare = value; 
                
            }
        }

        
    }
}
