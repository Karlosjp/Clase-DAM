package ejerciciospoo;

public class Punto {

	private double coordenadaX, coordenadaY;
	
	public Punto(double coordenadaX, double coordenadaY) {
		// TODO Auto-generated constructor stub
		this.coordenadaX = coordenadaX;
		this.coordenadaY = coordenadaY;
	}
	
	public String getPunto() {
		return "(" + coordenadaX + ", " + coordenadaY + ")";
	}
}
