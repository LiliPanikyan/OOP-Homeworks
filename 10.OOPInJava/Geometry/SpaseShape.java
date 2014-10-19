package Geometry;

public  abstract class SpaseShape extends Shape implements VolumeMeasurable{
	
	public SpaseShape(double pointX, double pointY, double pointZ) {	
		this.vertices = new Vertex3D[1];
		this.vertices[0] = new Vertex3D(pointX, pointY, pointZ);
	}
	
	public abstract double getArea();

	public abstract double getVolume();

	@Override
	public String toString(){
		return 
			"Shape: " + this.getClass().getSimpleName() + "\n" + 
			"Area: " + this.getArea() + "\n" +
			"Volume: " + this.getVolume() + "\n" +
			super.toString();			
}
	
}
