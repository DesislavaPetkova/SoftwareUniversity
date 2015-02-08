package geometry;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;


public class GeometryTesting{

	public static void main(String[] args) {
		
		Shape[] arrayShape = new Shape[] {
				new Triangle(1, 2, 3, 2, 3, 4),
				new Rectangle(2, 3, 4, 2),
				new Circle(2, 3.2, 5),
				new SquarePyramid(1, 2, 3, 4, 8),
				new Cuboid(1, 3, 2, 5, 2, 9),
				new Sphere(2, 3, 4, 5)
		};
		for (Shape shape : arrayShape) {
			System.out.println(shape);
		}
	
		List<Shape> largeVolumesList = Arrays.asList(arrayShape)
				.stream()
				.filter(s -> s instanceof VolumeMeasurable).filter(v ->((VolumeMeasurable) v)
				.getVolume() > 40)
				.collect(Collectors.toList());
		
		for (Shape shape : largeVolumesList) {
			System.out.println(shape);
		}
		
		Comparator<Shape> byPerimeter = (s1, s2) -> {
			PerimeterMeasurable Shape1 = (PerimeterMeasurable) s1;
			PerimeterMeasurable Shape2 = (PerimeterMeasurable) s2;
			double perimeterShape1 = Shape1.CalculatePerimeter();
			double perimeterShape2 = Shape2.CalculatePerimeter();
			
			return perimeterShape1 < perimeterShape2 ? -1 :
				perimeterShape1 > perimeterShape2 ? 1 : 0;		
		};
		
		List<Shape> planeShapesByPerimeter = Arrays.asList(arrayShape)
				.stream()
				.filter(p -> p instanceof PlaneShape)
				.sorted(byPerimeter)
				.collect(Collectors.toList());
		
		for (Shape shape : planeShapesByPerimeter) {
			System.out.println(shape);
		}
		
	}

}
