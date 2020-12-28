package ejercicio03;

public class Libro {
	private String strTitulo, strAutor;
	private int intEjemplares, intPrestados;

	public Libro() {
		this.strTitulo = "";
		this.strAutor = "";
		this.intEjemplares = 0;
		this.intPrestados = 0;
	}

	public Libro(String strTitulo, String strAutor, int intEjemplares, int intPrestados) {
		this.strTitulo = strTitulo;
		this.strAutor = strAutor;
		this.intEjemplares = intEjemplares;
		this.intPrestados = intPrestados;
	}

	public String getStrTitulo() {
		return strTitulo;
	}

	public String getStrAutor() {
		return strAutor;
	}

	public int getIntEjemplares() {
		return intEjemplares;
	}

	public int getIntPrestados() {
		return intPrestados;
	}

	public void setStrTitulo(String strTitulo) {
		this.strTitulo = strTitulo;
	}

	public void setStrAutor(String strAutor) {
		this.strAutor = strAutor;
	}

	public void setIntEjemplares(int intEjemplares) {
		this.intEjemplares = intEjemplares;
	}

	public void setIntPrestados(int intPrestados) {
		this.intPrestados = intPrestados;
	}

	
	public boolean prestamo() {
		boolean booPrestado = false;
		
		if(this.intEjemplares > this.intPrestados) {
			this.intPrestados++;
			booPrestado = true;
		}
		
		return booPrestado;
	}
	
	public boolean devolucion() {
		boolean devolucion = false;
		
		if(this.intPrestados > 0) {
			this.intPrestados--;
			devolucion = true;
		}
		
		return devolucion;
	}

	@Override
	public String toString() {
		return "Libro \\nTitulo: " + strTitulo + ", \\nAutor: " + strAutor + ", \\nEjemplares: " + intEjemplares
				+ ", \\nPrestados: " + intPrestados + "]";
	}
	
	
}
