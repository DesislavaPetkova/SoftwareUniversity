package geometry;

public class Cuboid extends SpaceShape{

	private double width;
	private double height;
	private double depth;
	
	public Cuboid(double x, double y, double z, double width, double height, double depth) {
		super(x, y, z);
		
		this.width = width;
		this.height = height;
		this.depth = depth;
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeigt() {
		return height;
	}

	public void setHeigt(double heigt) {
		this.height = heigt;
	}

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		this.depth = depth;
	}

	
	
	
	@Override
	public double getVolume() {
		
		return  this.width*this.height*this.depth;
	}

	@Override
	public double CalculateArea() {
		return 2*this.width* this.depth + 2*this.depth*this.height + 2*this.height* this.width;
	}

	@Override
	public String toString() {
		return "Cuboid [width=" + width + ", height=" + height + ", depth="
				+ depth + ", getVolume()=" + getVolume() + ", CalculateArea()="
				+ CalculateArea() + "]";
	}
	
	
}
