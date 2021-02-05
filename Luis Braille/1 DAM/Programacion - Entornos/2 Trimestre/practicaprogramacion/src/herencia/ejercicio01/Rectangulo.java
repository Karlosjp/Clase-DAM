package herencia.ejercicio01;

public class Rectangulo {
	private Punto punto1;
	private Punto punto2;

	public Rectangulo() {
		this.punto1 = new Punto(0, 0);
		this.punto2 = new Punto(1, 1);
	}

	public Rectangulo(int intX1, int intX2, int intY1, int intY2) {
		this.punto1 = new Punto(intX1, intY1);
		this.punto2 = new Punto(intX2, intY2);
	}

	public Rectangulo(Punto punto1, Punto punto2) {
		this.punto1 = punto1;
		this.punto2 = punto2;
	}

	public Rectangulo(int intBase, int intAltura) {
		this.punto1 = new Punto(0, 0);
		this.punto2 = new Punto(punto1.getX() - intBase, intAltura);
	}

	public Rectangulo(Rectangulo objRectangulo) {
		this.punto1 = objRectangulo.getPunto1();
		this.punto2 = objRectangulo.getPunto2();
	}

	public Punto getPunto1() {
		return punto1;
	}

	public Punto getPunto2() {
		return punto2;
	}

}
