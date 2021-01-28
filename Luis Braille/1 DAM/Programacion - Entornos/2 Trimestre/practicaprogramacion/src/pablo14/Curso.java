package pablo14;

import java.util.Arrays;

public class Curso {
	
	String nombre;
	String[] asignaturas;
	Alumno[] alumnos;
	int n_alumnos;
	
	int pos = 0;
	public Curso(String nombre, String ... asignaturas) {
		super();
		this.asignaturas = new String[5];
		alumnos = new Alumno[15];
		
		this.nombre = nombre;
		this.asignaturas = asignaturas;
		
		for (String x: asignaturas) {
			this.asignaturas[pos] = x;
			pos++;
		}
	}
	
	
	public void addAlumno(Alumno alm) {
		alumnos[n_alumnos] = alm;
		n_alumnos++;
	}


	@Override
	public String toString() {
		return "Curso [nombre=" + nombre + ", asignaturas=" + Arrays.toString(asignaturas) + ", alumnos="
				+ Arrays.toString(alumnos) + "]";
	}
	
	
	
	
	
}
