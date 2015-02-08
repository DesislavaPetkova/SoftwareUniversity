using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Salad : Meal, ISalad
    {
        private bool containsPasta;


        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta) 
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.ContainsPasta = containsPasta;
            this.isVegan = true;
        }

        public bool ContainsPasta 
        {
            get
            {
                return this.containsPasta; 
                
            }
            private set
            {
                this.containsPasta = value; 
                
            } 
        }

        public override string ToString()
        {
            string pasta;
            if (this.ContainsPasta)
            {
                pasta = "yes";
            }
            else
            {
                pasta = "no";
            }
            string header = string.Format("~~~~~ SALADS ~~~~~");
            string result = string.Format("[VEGAN] ==  {0} == ${1:##.###}\nPer serving: {2} g, {3} kcal\nReady in {4} minutes\nContains pasta: {5}", this.Name, this.Price, this.QuantityPerServing, this.Calories, this.TimeToPrepare, pasta);
            return header + "\n" + result;
        }
    }
}
