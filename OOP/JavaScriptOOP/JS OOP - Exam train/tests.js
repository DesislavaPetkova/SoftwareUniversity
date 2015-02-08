Object.prototype.extends = function (parent) {
  this.prototype = Object.create(parent.prototype);
  this.prototype.constructor = this; 
}



var Restaurant = (function() {
		'use strict';
	
		function Restaurant(name, location) {
			this.setName(name);
			this.setLocation(name);
			this._recipes = [];	
				
		}

		Restaurant.prototype.setName = function(){
			return this._name = name;
		}
		Restaurant.prototype.setLocation = function(){
			this._location = location;
		}

		Restaurant.prototype.getName = function() {
			return this._name;
		};
		Restaurant.prototype.getLocation = function() {
			return this._location;
		};

		Restaurant.prototype.addRecipe = function(recipe) {
			this._recipes.push(recipe); 
		};

		Restaurant.prototype.removeRecipe = function(recipe) {

        };

		Restaurant.prototype.toString = function(){
			return "Restaurant name: "+ this._name+ " Address: "+this._location+ " Recipes: "+Object.RECIPES;
		}

		Restaurant.prototype.printRestaurantMenu = function(){
			//TODO
		};

		return Restaurant;
	
	}());	



var Recipe = (function() {
	'use strict';

	function Recipe(name, price, calories, quantity, timeToPrepare) {
		// enforces new
		if (!(this instanceof Recipe)) {
			return new Recipe();
		}
		//constructor body
		if (this.constructor === Recipe) {
	      throw new Error("Can't instantiate abstract class!");	      
	    }	

	    this.setName(name);
	    this.setPrice(price);
	    this.setCalories(calories);
	    this._calories = calories;
	    this._quantity = quantity;
	    this._timeToPrepare = timeToPrepare;

		}

	

	Recipe.prototype.toString = function(){
			return this.constructor.name+" Name: "+ this._name+" Price: "+this._price +" Calories: "+this._calories + " Quantity: "+this._quantity + " timeToPrepare: "+this._timeToPrepare;
	}

	Recipe.prototype.setName = function() {
		this._name = name;
	};

	Recipe.prototype.Price = function() {
		this._price = price;
	};





	return Recipe;

}());

var Drink = (function() {
	'use strict';
	Drink.extends(Recipe);
	function Drink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
		// enforces new
		if (!(this instanceof Drink)) {
			return new Drink(args);
		}
		
		// constructor body
		Recipe.apply(this, arguments);
		this._isCarbonated = isCarbonated;

	}

	Drink.prototype.toString = function() {
		var carbonated = this._isCarbonated? "Yes": "No";
		return Recipe.prototype.toString.call(this)+ " isCarbonated: "+ carbonated; 
	};

	return Drink;

}());

var Meal = (function() {
	'use strict';
	Meal.extends(Recipe);
	function Meal(name, price, calories, quantity, timeToPrepare, isVegan) {
		// enforces new
		if (!(this instanceof Meal)) {
			return new Meal(args);
		}

		if (this.constructor === Meal) {
	      throw new Error("Can't instantiate abstract class!");	      
	    }
		// constructor body
		Recipe.call(this, name, price, calories, quantity, timeToPrepare);
		this._isVegan = isVegan;

	}
	

	Meal.prototype.toString = function() {
		var isVegan = this._isVegan? "Yes": "No";
		return Recipe.prototype.toString.call(this) + " Is vegan: "+isVegan;
	};
	Meal.prototype.VeganToggle = function(first_argument) {
		if(this._isVegan){
			return this._isVegan = false;
		} else{
			return this._isVegan = true;
		}

	};

	return Meal;

}());

var Dessert = (function() {
	'use strict';
	Dessert.extends(Meal);
	function Dessert(name, price, calories, quantity, timeToPrepare, isVegan, withSugar) {
		// enforces new
		if (!(this instanceof Dessert)) {
			return new Dessert(args);
		}
		Meal.apply(this, arguments);
		// constructor body
		this._withSugar = withSugar;
	}

	Dessert.prototype.toString = function() {
		var sugar = this._withSugar ? "Yes": "No";
		return Meal.prototype.toString.call(this) + " with Sugar: "+sugar;
	};

	return Dessert;

}());

// var test1 = new Recipe("wewe", 2323, 23242, 454, 23);
var test2 = new Drink("Coffe", 4354, 232 ,566, 2, false)
var choko = new Dessert("Torta Garaj", 2323, 23242, 454, 23, false,true);
var rest1 = new Restaurant("Bqla Gora", "Sofia");

Restaurant.prototype.Add(test2);
Restaurant.prototype.Add(choko);
console.log(rest1.toString());
// console.log(Object.prototype.RECIPES);
