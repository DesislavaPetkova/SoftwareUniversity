using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    using System;
    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;

    public class RecipeFactory : IRecipeFactory
    {
        private const string Soup = "Soup";
        private const string Entree = "Entree";
        private const string Pasta = "Pasta";
        private const string Side = "Side";
        private const string Meat = "Meat";
        private const string Other = "Other";
        private const string InvalidCourseType = "Invalid Course Type: {0}";


        public IDrink CreateDrink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
        {
            Drink drink = new Drink(name, price, calories, quantityPerServing, timeToPrepare, isCarbonated);
            return drink;
        }

        public ISalad CreateSalad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
        {
            
            Salad salad = new Salad(name, price, calories, quantityPerServing, timeToPrepare, containsPasta);
            return salad;
        }
        
        public IMainCourse CreateMainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
        {
            MainCourseType mainType = getMainCourseType(type);
            MainCourse mainCourse = new MainCourse(name, price, calories, quantityPerServing, timeToPrepare, isVegan, mainType);
            return mainCourse;
        }

        public IDessert CreateDessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
        {
            Dessert dessert = new Dessert(name, price, calories, quantityPerServing, timeToPrepare, isVegan);
            return dessert;
        }

        private MainCourseType getMainCourseType(string type)
        {
            switch (type)
            {
                case Soup:
                    return MainCourseType.Soup;
                case Entree:
                    return MainCourseType.Entree;
                case Pasta:
                    return MainCourseType.Pasta;
                case Side:
                    return MainCourseType.Side;
                case Meat:
                    return MainCourseType.Meat;
                case Other:
                    return MainCourseType.Other;
                default:
                    throw new ArgumentException(string.Format(InvalidCourseType, type));
            }
        }
        
    }
}
