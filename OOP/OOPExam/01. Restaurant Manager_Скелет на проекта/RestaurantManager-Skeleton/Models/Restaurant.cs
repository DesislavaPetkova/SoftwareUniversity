using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        private IList<IRecipe> recipes = new List<IRecipe>(); 

        public Restaurant(string name, string location)
        {
            
            this.Name = name;
            this.Location = location;
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

        public string Location
        {
            get { return this.location; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid Location");
                }
                this.location = value; 
                
            }
        }

        public IList<Interfaces.IRecipe> Recipes
        {
            get { return this.recipes; }
        }

        public void AddRecipe(Interfaces.IRecipe recipe)
        {
            this.recipes.Add(recipe);
        }

        public void RemoveRecipe(Interfaces.IRecipe recipe)
        {
            this.recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder menu = new StringBuilder();
            string menuHeader = string.Format("***** {0} - {1} *****", this.Name, this.Location);
            menu.AppendLine(menuHeader);
            
            if (this.recipes.Count() == 0)
            {
                menu.AppendFormat("No recipes... yet");
                return menu.ToString();
            }
            List<IRecipe> newList = Recipes.OrderBy(r => r.Name).ToList();
            foreach (var recipe in newList)
            {
                string menuStr = recipe.ToString();
                menu.Append(menuStr);
                menu.AppendLine();

            }

            return menu.ToString();
        }

        
    }
}
