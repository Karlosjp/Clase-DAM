package ePersonas;

public class Persona {
	private String nombre, apellido;
	private int edad;

	public Persona(String nombre, String apellido, int edad) {
		this.nombre = nombre;
		this.apellido = apellido;
		this.edad = edad;
	}

	public String getNombre() {
		return "Nombre: " + nombre;
	}

	public String getApellido() {
		return "Apellido: " + apellido;
	}

	public String getEdad() {
		return "Edad: " + edad;
	}
	public String imprimir() {
		return "Nombre: " + nombre + "Apellido: " + apellido + " edad: " + edad;
	}

	public void vaciar() {
		nombre = "";
		apellido = "";
		edad = 0;
	}
}
