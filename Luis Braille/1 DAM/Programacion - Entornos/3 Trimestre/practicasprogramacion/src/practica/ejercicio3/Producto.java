package practica.ejercicio3;

public class Producto {
	private String strNombre;
	private int intCantidad;
	private double douPrecio;

	public Producto(String strNombre) {
		super();
		this.strNombre = strNombre;
		this.intCantidad = 0;
		this.douPrecio = 0;
	}

	public Producto(String strNombre, double douPrecio) {
		super();
		this.strNombre = strNombre;
		this.intCantidad = 0;
		this.douPrecio = douPrecio;
	}

	public String getStrNombre() {
		return strNombre;
	}

	public double getDouPrecio() {
		return douPrecio;
	}

	public int getIntCantidad() {
		return intCantidad;
	}

	public void incrementarIntCantidad() {
		this.intCantidad++;
	}

	public void reducirIntCantidad() {
		this.intCantidad--;
	}

	@Override
	public String toString() {
		return "Producto [strNombre=" + strNombre + ", intCantidad=" + intCantidad + ", douPrecio=" + douPrecio + "]";
	}

}
