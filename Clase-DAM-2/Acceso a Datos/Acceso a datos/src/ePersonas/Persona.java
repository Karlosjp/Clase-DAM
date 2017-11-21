package ePersonas;

public class Persona {
	private String nombre, apellido;
	private int edad;

	public Persona() {
		nombre = "";
		apellido = "";
		edad = 0;
	}

	public Persona(String nombre, String apellido, int edad) {
		this.nombre = nombre;
		this.apellido = apellido;
		this.edad = edad;
	}

	public String getNombre() {
		return nombre;
	}

	public String getApellido() {
		return apellido;
	}

	public int getEdad() {
		return edad;
	}

	public void setNombre(String n) {
		this.nombre = n;
	}

	public void setApellido(String a) {
		this.apellido = a;
	}

	public void setEdad(int e) {
		this.edad = e;
	}

	public String imprimir() {
		return "Nombre: " + nombre + "\tApellido: " + apellido + "\tedad: " + edad;
	}

	public void vaciar() {
		nombre = "";
		apellido = "";
		edad = 0;
	}
}
