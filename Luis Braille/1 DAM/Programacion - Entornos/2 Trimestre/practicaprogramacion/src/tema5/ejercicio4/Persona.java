package tema5.ejercicio4;

public class Persona {
	protected String strNombre;
	protected int intEdad;

	public Persona(String strNombre, int intEdad) {
		this.strNombre = strNombre;
		this.intEdad = intEdad;
	}

	public void mostrar() {
		System.out.println("Nombre: " + strNombre);
		System.out.println("Edad " + intEdad);
	}
}
