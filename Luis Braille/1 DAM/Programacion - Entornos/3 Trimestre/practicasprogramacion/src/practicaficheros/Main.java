package practicaficheros;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Main {

	public static void main(String[] args) {
		/*
		 * Realizar un programa en java que me permita almacenar alumnos. Los alumnos se
		 * identificaran por su codigo de expediente, y tendran su nombre, apelldios,
		 * ciclo formativo y una lista de asignaturas con sus notas. Esta informacion la
		 * tendremos en un objeto map, que almacenaremos en un fichero para que no se
		 * pierda
		 */

		List<Asignatura> liAsignaturas = new ArrayList<>();
		liAsignaturas.add(new Asignatura("FOL", 5));
		liAsignaturas.add(new Asignatura("Entornos", 0));
		liAsignaturas.add(new Asignatura("BBDD", 8));
		liAsignaturas.add(new Asignatura("Marcas", 0));
		liAsignaturas.add(new Asignatura("Sistemas", 0));
		liAsignaturas.add(new Asignatura("Programacion", 5));

		Alumno objAlumno1 = new Alumno("256x4", "Carlos", "Jaquez", "1DAM", liAsignaturas);
		Alumno objAlumno2 = new Alumno("226x4", "Anny", "Jaquez", "1DAM", liAsignaturas);
		Alumno objAlumno3 = new Alumno("246x4", "Mario", "Jaquez", "1DAM", liAsignaturas);
		Alumno objAlumno4 = new Alumno("251x4", "Josue", "Jaquez", "1DAM", liAsignaturas);
		Alumno objAlumno5 = new Alumno("254x4", "CarlosJ", "Jaquez", "1DAM", liAsignaturas);

		Map<String, Alumno> hmAlumnos = new HashMap<>();
		hmAlumnos.put(objAlumno1.getStrCodExpediente(), objAlumno1);
		hmAlumnos.put(objAlumno2.getStrCodExpediente(), objAlumno2);
		hmAlumnos.put(objAlumno3.getStrCodExpediente(), objAlumno3);
		hmAlumnos.put(objAlumno4.getStrCodExpediente(), objAlumno4);
		hmAlumnos.put(objAlumno5.getStrCodExpediente(), objAlumno5);

		String ruta = "." + File.separatorChar + "";

		try {
			BufferedWriter bw = new BufferedWriter(new FileWriter("flAlumnos.txt"));
			
			for (Map.Entry<String, Alumno> entry : hmAlumnos.entrySet())
				bw.write(entry.getValue()+"\n");
			
			bw.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
