package ficheros;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class CrearFichero {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		System.out.println("Escribe nombre de carpeta");
		String CNombre = scan.nextLine();

		System.out.println("Escribe nombre para fichero");
		String FNombre = scan.nextLine();

		File carpeta = new File(CNombre);
		File fichero = new File(CNombre + "/" + FNombre + ".txt");

		carpeta.mkdir();

		try {
			fichero.createNewFile();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
