package geometry;

import java.util.Arrays;



public class Triangle extends PlaneShape{

	public Triangle(double x, double y, double x1, double y1, double x2, double y2) {
		super(x, y);
		this.vertices[1] = new Vertex2D(x1, y1);
		this.vertices[2] = new Vertex2D(x2, y2);
	}

	@Override
	public double CalculateArea() {
		double p = CalculatePerimeter();
		return Math.sqrt(p * (p - (vertices[0].x + vertices[0].y))* (p-(vertices[1].x + vertices[1].y)) * (p-(vertices[2].x + vertices[2].y)));
	}

	@Override
	public double CalculatePerimeter() {
		return (((vertices[0].x + vertices[0].y)+ (vertices[1].x + vertices[1].y)+ (vertices[2].x + vertices[2].y)) /2);
	}

	@Override
	public String toString() {
		return "Triangle ["
				+ (vertices != null ? "vertices=" + Arrays.toString(vertices)
						+ ", " : "") + "CalculateArea()=" + CalculateArea()
				+ ", CalculatePerimeter()=" + CalculatePerimeter() + "]";
	}

	

	
	
	
}
