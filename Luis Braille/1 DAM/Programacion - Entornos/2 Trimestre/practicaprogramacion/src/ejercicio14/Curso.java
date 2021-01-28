package ejercicio14;

public class Curso {
	
	private String strGrupo;
	private int intNivel;
	private Alumno[] alumnos;
	private String[][] strNotas;
 
	public Curso(String strGrupo, int intNivel) {
		super();
		this.strGrupo = strGrupo;
		this.intNivel = intNivel;
		this.alumnos = new Alumno[30];
		
	}

}
