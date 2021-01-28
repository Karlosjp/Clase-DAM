package pablo14;

import java.util.Arrays;

public class Alumno {
	String nombre;
	String curso;
	String[] asignaturas = new String[5];
	
	
	int pos = 0;
	public Alumno(String nombre, String curso, String ... asignaturas) {
		super();
		this.nombre = nombre;
		this.curso = curso;
		for (String x: asignaturas) {
			this.asignaturas[pos] = x;
			pos++;
		}
	}
	
	int asig_pos = 0;
	public void addAsignatura(String asig) {
		this.asignaturas[asig_pos] = asig;
		asig_pos++;
	}
	//override
	@Override
	public String toString() {
		return "alumno [nombre=" + nombre + ", curso=" + curso + ", asignaturas=" + Arrays.toString(asignaturas) + "]";
	}
}
