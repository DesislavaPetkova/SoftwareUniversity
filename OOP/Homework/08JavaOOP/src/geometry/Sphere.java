package geometry;



public class Sphere extends SpaceShape{
	
	private double radius;

	public Sphere(double x, double y, double z, double radius) {
		super(x, y, z);
		this.radius = radius;
		
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}

	@Override
	public double getVolume() {
		return (4 * Math.PI * Math.pow(radius, 3))/3;
	}

	@Override
	public double CalculateArea() {
		return 4 * Math.PI * Math.pow(radius, 2);
	}

	@Override
	public String toString() {
		return "Sphere [radius=" + radius + ", getVolume()=" + getVolume()
				+ ", CalculateArea()=" + CalculateArea() + "]";
	}

	
	
	
	

}
