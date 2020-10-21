package examen;

public class Producto {

	private String nombre;
	private double precio;

	public void Producto() {
		nombre = "";
		precio = 0;
	}

	public void setNombre(String n) {
		nombre = n;
	}

	public void setPrecio(double p) {
		precio = p;
	}

	public String escribir() {
		return "Nombre: " + nombre + ". Precio: " + precio;
	}

	public void modPrecioPorcentaje(double mod) {
		precio *= mod;
	}
}
