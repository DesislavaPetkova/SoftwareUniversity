package geometry;

public class Circle extends PlaneShape{

	private double radius;

	public Circle(double x, double y, double radius) {
		super(x, y);
		
		this.radius = radius;
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}

	@Override
	public double CalculateArea() {
		return Math.PI * Math.pow(radius, 2);
	}

	@Override
	public double CalculatePerimeter() {
		return 2* Math.PI * this.radius;
	}

	@Override
	public String toString() {
		return "Circle [radius="
				+ radius
				+ ", "
				+ (vertices != null ? "vertices=" + vertices[0]
						: "") + "]";
	}
	
	
	
}
