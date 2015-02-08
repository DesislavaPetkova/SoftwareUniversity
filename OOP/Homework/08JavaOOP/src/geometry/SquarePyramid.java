package geometry;



public class SquarePyramid extends SpaceShape{

	private double baseWidth;
	private double height;
	
	
	public SquarePyramid(double x, double y, double z, double baseWidth, double height) {
		super(x, y, z);
		this.baseWidth = baseWidth;
		this.height = height;
		
	}

	
	public double getBaseWidth() {
		return baseWidth;
	}


	public void setBaseWidth(double baseWidth) {
		this.baseWidth = baseWidth;
	}


	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	
	
	public double baseArea(){
		return this.baseWidth * this.baseWidth;
	} 	
	
	public double slantLenght(){
		return Math.sqrt(this.height * this.height + (0.25 * (this.baseWidth*this.baseWidth)));
	} 


	

	@Override
	public double getVolume() {
		double result = 0.3 * baseArea() * this.height;
		return result;
	}

	@Override
	public double CalculateArea() {
		double result = baseArea() + 0.5*(4*this.baseWidth)*slantLenght();
		return result;
	}


	@Override
	public String toString() {
		return "SquarePyramid [baseWidth=" + baseWidth + ", height=" + height
				+ ", BaseArea=" + baseArea() + ", slantLenght=" + slantLenght()
				+ ", getVolume()=" + getVolume() + ", CalculateArea()="
				+ CalculateArea() + "]";
	}


	
	

	
}
