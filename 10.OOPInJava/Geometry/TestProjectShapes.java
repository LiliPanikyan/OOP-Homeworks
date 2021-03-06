package Geometry;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

import OneLevShop.Product;

public class TestProjectShapes {

	public static void main(String[] args) {
		List<Shape> shapes = new ArrayList<Shape>();
        shapes.add(new Rectangle(10, -70, 3, 22));
        shapes.add(new Circle(122, -17, 13));
        shapes.add(new Triangle(1, -7, 3, 11, 20, 30));
        shapes.add(new SquarePyramid(1, -7, 3, 11, 1, 2));
        shapes.add(new Cuboid(1, -7, 3, 11, 20, 30));
        shapes.add(new Sphere(97, -12, 3, 50));
               
        shapes.stream()
                .filter(s -> s instanceof VolumeMeasurable)
                .filter(v -> ((VolumeMeasurable)v).getVolume() > 40)
        		.forEach((s) -> System.out.println(s + "\n"));
        
        Comparator<Shape> orderByPerimeter =(s1, s2) -> Double.compare(
        		(((PlaneShape)s1).getPerimeter()),
        		(((PlaneShape)s2).getPerimeter()));
        
        shapes.stream()
		        .filter(s -> s instanceof PlaneShape)
		        .sorted(orderByPerimeter)
				.forEach((s) -> System.out.println(s + "\n"));
	}
	
}
