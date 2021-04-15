package practica.ejercicio2;

public class Alumno {
	protected String nombre;
	protected double nota;

	// constructor
	public Alumno(String n, double nt) {
		nombre = n;
		nota = nt;
	}

	public boolean equals(Object obj) {
		if (obj instanceof Alumno) {
			Alumno a = (Alumno) obj;
			return a.nombre.equals(nombre) && a.nota == nota;
		} else
			return false;
	}

	public int hashCode() {
		return nombre.hashCode() + (int) nota * 10000;
	}

	public String toString() {
		return nombre + "-" + nota;
	}
}
