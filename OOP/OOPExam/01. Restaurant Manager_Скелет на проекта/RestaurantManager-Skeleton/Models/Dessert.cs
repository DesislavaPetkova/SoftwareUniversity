using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    class Dessert : Meal, IDessert
    {
        private bool withSugar = true;

        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            :base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.WithSugar=withSugar;
            this.isVegan = isVegan;
        }

        public bool WithSugar
        {
            get { return this.withSugar; }
            set { this.withSugar = value; }
        }

        public void ToggleSugar()
        {
            if (this.withSugar)
            {
                this.withSugar = false;
            }
            else
            {
                this.withSugar = false;
            }
        }


        public override string ToString()
        {
            string header = string.Format("~~~~~ DESSERTS ~~~~~");
            string result = string.Format("{0}{1}==  {2} == ${3:##.###}\nPer serving: {4} g, {5} kcal\nReady in {6} minutes", this.withSugar ? "" : "[NO SUGAR] ", this.isVegan ? "[VEGAN] " : "", this.Name, this.Price, this.QuantityPerServing, this.Calories, this.TimeToPrepare);
            return header + "\n" + result;
        }
    }
}
