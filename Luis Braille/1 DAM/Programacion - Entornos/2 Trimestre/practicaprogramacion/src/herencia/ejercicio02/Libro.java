package herencia.ejercicio02;

public class Libro extends Publicacion implements Prestable {
	private boolean booPrestado;

	public Libro() {
		this.booPrestado = false;
	}

	public Libro(String strIsbn, String strTitulo, int intAnhoPublicacion) {
		super(strIsbn, strTitulo, intAnhoPublicacion);
		this.booPrestado = false;
	}

	@Override
	public void presta() {
		this.booPrestado = true;

	}

	@Override
	public void devuelve() {
		this.booPrestado = false;
	}

	@Override
	public boolean estaPrestado() {
		return this.booPrestado;
	}

	@Override
	public String toString() {
		if (booPrestado)
			return super.toString() + " " + "(prestado)";
		else
			return super.toString()  + " " + " (no prestado)";
	}
}
