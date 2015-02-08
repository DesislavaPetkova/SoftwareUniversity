using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManager
{
    public class Drink : Recipe, RestaurantManager.Interfaces.IDrink
    {
        private bool isCarbonated;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated):base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
        }

        public override int Calories {
            get
            {
                return this.calories;
            }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Calories in drinks should be less than 100");
                }
                this.calories = value;
            } 
        }

        public override int TimeToPrepare {
            get { return this.timeToPrepare; }
            set
            {
                if (value > 20)
                {
                    throw new ArgumentException("Time to prepare should be less than 20 mins");
                }
                this.timeToPrepare = value;
            }
        }


        public bool IsCarbonated
        {
            get { return this.isCarbonated; }
            set { this.isCarbonated = value; }
        }

        public override string ToString()
        {
            string carbonated;
            if (this.IsCarbonated == false)
            {
                carbonated = "no";
            }
            else
            {
                carbonated = "yes";
            }
            string header = string.Format("~~~~~ DRINKS ~~~~~");
            string result =
                string.Format("==  {0} == ${1:##.###}\nPer serving: {2} ml, {3} kcal\nReady in {4} minutes\nCarbonated: {5}",
                    this.Name, this.Price, this.QuantityPerServing, this.Calories, this.TimeToPrepare,
                    carbonated);
            return header +"\n"+result;
        }
    }
}
