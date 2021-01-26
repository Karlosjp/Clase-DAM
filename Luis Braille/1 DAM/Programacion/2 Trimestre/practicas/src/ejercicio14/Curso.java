package ejercicio14;

public class Curso {
	private Asignatura[] asignaturas;
	private int intNivel;
	
	public Curso () {
		asignaturas = new Asignatura[6];
		intNivel = 1;
	}
	
	public Curso (Asignatura[] asignaturas, int intNivel) {
		this.asignaturas = asignaturas;
		this.intNivel = intNivel;
	}

}
