package geometry;

public class Rectangle extends PlaneShape {

	private double width;
	private double height;
	
	public Rectangle(double x, double y, double width, double height) {
		super(x, y);
		this.width = width;
		this.height = height;
		
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	@Override
	public double CalculateArea() {
		return width * height;
	}

	@Override
	public double CalculatePerimeter() {
		return 2* (this.width + this.height);
	}

	@Override
	public String toString() {
		return "Rectangle "+ vertices[0] + ", " +"width : " +this.width + ", " + " height: "+ this.height;

	}
}
