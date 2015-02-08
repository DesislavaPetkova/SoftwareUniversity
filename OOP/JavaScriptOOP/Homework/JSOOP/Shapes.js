var Shapes = (function(){

	Object.prototype.inherits = function(parent) {
	this.prototype = Object.create(parent.prototype);
	this.prototype.constructor = this;
	}; // Method for all objects which allow them to inherits other "Abstract classes"




	var Point = (function() {
		'use strict';		

		function Point(x, y) {
			// enforces new
			if (!(this instanceof Point)) {
				return new Point(x, y);
			}
			this._x = x;
			this._y = y;
		}

		

		Point.prototype.toString = function() {
			return " "+this._x +" "+ this._y;
		};

		return Point;

	}());


	var Shape = (function() {
		'use strict';

		Shape.inherits(Point)


		function Shape(x, y, color) {
			// enforces new
			if (!(this instanceof Shape)) {
				return new Shape(x, y, color);
			}
			Point.call(this, x, y)
			this._color = color;
		}

		Shape.prototype.draw = function() {
			// TO DO with canvas
		};
		Shape.prototype.toString = function(){
			return "Point X: "+this._x+ " Point Y: "+ this._y+" Color: "+this._color;
		}

		return Shape;

	}());





	var Circle = (function() {
		'use strict';

		Circle.inherits(Shape);

		function Circle(x, y, color, radius) {
			// enforces new
			if (!(this instanceof Circle)) {
				return new Circle(x, y, color, radius);
			}
			Shape.call(this, x, y, color)
			this._radius = radius;
		}

		Circle.prototype.toString = function() {
			return "Circle || "+ Shape.prototype.toString.call(this) + " Radius: "+this._radius;
		};

		Circle.prototype.draw = function(){
			var c = document.getElementById("myCanvas");
			var ctx = c.getContext("2d");
			ctx.beginPath();
			ctx.arc(this._x, this._y, 50, 0, this._radius * Math.PI);
			ctx.stroke();		
		};

		return Circle;

	}());



	var Rectangle = (function() {
	'use strict';

		Rectangle.inherits(Shape);

		function Rectangle(x, y, color, width, height) {
			// enforces new
			if (!(this instanceof Rectangle)) {
				return new Rectangle(x, y, color, width, height);
			}
			Shape.call(this, x, y, color)
			// constructor body
			this._width = width;
			this._height = height;
		}

		Rectangle.prototype.draw = function() {
	        
	        var c = document.getElementById("myCanvas");
			var ctx = c.getContext("2d");
			ctx.beginPath();
			ctx.lineWidth = "4";
			ctx.strokeStyle = this._color;
			ctx.rect(this._x, this._y, this._width, this._height); 
			ctx.stroke();				
		 };


		Rectangle.prototype.toString = function() {
		// method body
			return "Rectangle || "+Shape.prototype.toString.call(this) + " Width: "+ this._width + " Height: "+ this._height;
		};

		return Rectangle;

	}());



	var Triangle = (function() {
		'use strict';
		
		Triangle.inherits(Shape);

		function Triangle(pointA, pointB, pointC) {
			// enforces new
			if (!(this instanceof Triangle)) {
				return new Triangle(pointA, pointB, pointC);
			}
			Point.apply(this, arguments);

			
			// constructor body
		}

		Triangle.prototype.toString = function() {
			return "Triangle with points || "+ Point.prototype.toString.call(this)+ "";
		};

		Triangle.prototype.draw = function(){
			var c = document.getElementById("myCanvas");
			var ctx = c.getContext("2d");
			ctx.beginPath();
	        ctx.fillStyle = this._color;
	        ctx.moveTo(pointA._x , pointA._y);
	        ctx.lineTo(pointB._x + pointA._x, pointB._y + pointA._y);
	        ctx.lineTo(pointC._x + pointA._x, pointC._y + pointA._y);
	        ctx.fill();


		};

		return Triangle;

	}());




	var Segment = (function() {
			'use strict';
			
			Segment.inherits(Shape);
			function Segment(A, B) {
				// enforces new
				if (!(this instanceof Segment)) {
					return new Segment(args);
				}
				this._A = arguments[0];
				this._B = arguments[1];
			}
		
			Segment.prototype.toString = function() {
				return "Segment with points ||"+ this._A +" and "+this._B;
			};
		
			return Segment;
		
	}());	

	var shape = new Shape(5, 76, "#235476");
	console.log(shape.toString());

	// var circ = new Circle(100, 77, "#235476", 2);
	// circ.draw();

	var pravo = new Rectangle(223, 32, "#23223", 23, 54);
	console.log(pravo.toString());

	return {
		Rectangle: Rectangle,
		Point: Point,
		Shape: Shape,
		Circle: Circle,
		Triangle: Triangle
	}
	//End of the Namespace/Package or w/e shit is in JS...
}());

// var trian = new Shapes.Rectangle(100, 75, "#ffffff", 18, 23);
// console.log(trian.toString());