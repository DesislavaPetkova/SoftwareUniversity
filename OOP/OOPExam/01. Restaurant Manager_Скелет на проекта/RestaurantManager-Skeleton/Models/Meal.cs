using RestaurantManager.Interfaces;
using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManager
{
    public abstract class Meal : Recipe, IMeal
    {
        protected bool isVegan;
       

        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare) 
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.Unit = MetricUnit.Grams;
        }
        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : this(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Unit = MetricUnit.Grams;
        }

        public bool IsVegan
        {
            get { return this.isVegan; }
            set {}
        }

        public void ToggleVegan()
        {
            if (this.isVegan)
            {
                this.IsVegan = false;
            }
            else
            {
                this.IsVegan = true;
            }
        }
    }
}
