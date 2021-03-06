package Geometry;

public abstract class PlaneShape extends Shape{
	
	public PlaneShape(double pointX, double pointY) {
		this.vertices = new Vertex2D[3];
		this.vertices[0] = new Vertex2D(pointX, pointY);
		
	}
	
	public abstract double getPerimeter();

	public abstract double getArea();

	@Override
	public String toString(){
		return 
			"Shape: " + this.getClass().getSimpleName() + "\n" + 
			"Area: " + this.getArea() + "\n" +
			"Perimeter: " + this.getPerimeter() + "\n" +
			super.toString();			
	}
	
	
}
