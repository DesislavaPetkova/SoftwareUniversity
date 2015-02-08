package geometry;



public abstract class SpaceShape extends Shape implements AreaMeasurable,  VolumeMeasurable{

	public SpaceShape(double x, double y, double z) {
		this.vertices = new Vertex3D[1];
		vertices[0] = new Vertex3D(x, y, z);
		
	}

	

	@Override
	public abstract double getVolume();



	@Override
	public abstract double CalculateArea();



	@Override
	public abstract String toString();

	

	
	
	

}
