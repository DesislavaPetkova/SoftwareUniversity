using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    class MainCourse : Meal, IMainCourse
    {
        private MainCourseType type;



        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, MainCourseType type) 
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.isVegan = isVegan;
            this.Type = type;
        }

        public MainCourseType Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public override string ToString()
        {
            string header = string.Format("~~~~~ MAIN COURSES ~~~~~");
            string result = string.Format("{0}==  {1} == ${2:##.###}\nPer serving: {3} g, {4} kcal\nReady in {5} minutes\nType: {6}", this.isVegan ? "[VEGAN] " : "", this.Name, this.Price, this.QuantityPerServing, this.Calories, this.TimeToPrepare, this.Type);
            return header + "\n" + result;
        }
    }
}
