package pablo14;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);

		Curso curso1 = new Curso("1 Dam", "BD", "Entornos", "Programacion", "Sistemas");
		Curso curso2 = new Curso("2 Dam", "Aplicaciones Moviles", "Programacion", "Programacion 2");

		Curso[] cursos = new Curso[] { curso1, curso2 };
		
		int decision = 0;
		
		do {
			System.out.println("Pulsa 1 para mostrar los cursos");
			System.out.println("Pulsa 2 para añadir un nuevo alumno");
			System.out.println("Pulsa 3 para salir");
			decision = scn.nextInt();
			
			if(decision == 1) {
				//muestra el los cursos disponibles
				System.out.println("Cursos");
				for (int i = 0; i < cursos.length; i++) {
					System.out.println( i + "---" + cursos[i]);
				}
			}
			else if(decision == 2) {
				//Crea alumno
				System.out.println("Nuevo Alumno---->");
				System.out.println("nombre:");
				String nombre = scn.next();
				
				System.out.println("curso");
				int curso_elegido = scn.nextInt();
				String curso = cursos[curso_elegido].nombre;

				Alumno alm = new Alumno(nombre, curso);
				cursos[curso_elegido].addAlumno(alm);

				// da al alumno asignaturas
				for (int i = 0; i < cursos[curso_elegido].asignaturas.length; i++) {
					System.out.println("quieres esta asignatura:" + cursos[curso_elegido].asignaturas[i]);

					if (scn.next().equals("y")) {
						alm.addAsignatura(cursos[curso_elegido].asignaturas[i]);
					}
				}
			}
			
		}
		while(decision < 3);
		scn.close();
	}

}
