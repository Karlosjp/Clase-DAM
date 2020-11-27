package ejerciciospoo;

public class Linea {
	private Punto p1, p2;
	
	public Linea(Punto p1, Punto p2) {
		// TODO Auto-generated constructor stub
		this.p1 = p1;
		this.p2 = p2;
	}
	
	public String toString(){
		return "Línea formada por los puntos " + p1.toString() + " y " + p2.toString();
	}
}
