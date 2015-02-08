package geometry;
import geometry.AreaMeasurable;
import geometry.PerimeterMeasurable;
public abstract class PlaneShape extends Shape implements AreaMeasurable, PerimeterMeasurable{
	
	
	public PlaneShape(double x, double y) {
		
		this.vertices = new Vertex2D[3];
		this.vertices[0] = new Vertex2D(x, y);
		
	}

	@Override
	public abstract double CalculatePerimeter(); 

	@Override
	public abstract double CalculateArea();

	
	
	

}
