package ejerciciosFecha;

public class Persona {

	String nombre, apellidos;

	Fecha fecha = new Fecha();
	NIF dni = new NIF();

	public Persona(String nombre, String apellidos, Fecha fecha, NIF dni) {
		super();
		this.nombre = nombre;
		this.apellidos = apellidos;
		this.fecha = fecha;
		this.dni = dni;
	}

}
