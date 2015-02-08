package geometry;



public abstract class Shape implements AreaMeasurable, PerimeterMeasurable, VolumeMeasurable{
	
	protected Vertex[] vertices;

	protected Shape() {
		
		this.vertices = new Vertex[1];
	}

	
	@Override
	public double CalculatePerimeter() {
		// TODO Auto-generated method stub
		return 0;
	}


	@Override
	public double CalculateArea() {
		// TODO Auto-generated method stub
		return 0;
	}
	
	

	@Override
	public double getVolume() {
		// TODO Auto-generated method stub
		return 0;
	}


	public Vertex[] getVertices() {
		return vertices;
	}


	public void setVertices(Vertex[] vertices) {
		this.vertices = vertices;
	}


	@Override
	public String toString() {
		return this.vertices[0].toString();
	}
	
	
	
	
	
}
