package ficheros;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class MenuOpciones {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int opcion;

		do {
			menu();
			System.out.print("\t");
			opcion = scan.nextInt();
			scan.reset();

			File fichero;

			switch (opcion) {
				case 1 :
					System.out.print("\tEscribe nombre del fichero\n\t");
					String FNombre = scan.nextLine();
					// scan.reset();

					fichero = new File(FNombre + ".txt");

					creFichero(fichero);
					break;
				case 2 :
					System.out.print("\tQue fichero buscas:\n\t");
					fichero = new File(scan.nextLine());
					scan.reset();

					infFichero(fichero);
					break;
				case 3 :
					System.out.print("\tQue fichero buscas:\n\t");
					fichero = new File(scan.nextLine());
					scan.reset();

					longitud(fichero);
					break;
				case 4 :
					System.out.print("\tQue fichero buscas:\n\t");
					fichero = new File(scan.nextLine());
					scan.reset();

					existe(fichero);
					break;
				case 5 :
					System.out.print("\t¿Que fichero quieres borrar?:\n\t");
					fichero = new File(scan.nextLine());
					scan.reset();

					borrar(fichero);
					break;
				case 0 :
					System.exit(0);
					break;
				default :

			}
		} while (opcion != 6);

	}

	private static void menu() {
		System.out.println("Bienvenido al menu");
		System.out.println("Elige una opcion: ");
		System.out.println("\t 1. Crear Fichero.");
		System.out.println("\t 2. Mostrar fichero.");
		System.out.println("\t 3. Mostrar longitud del fichero.");
		System.out.println("\t 4. Comprobar si existe.");
		System.out.println("\t 5. Borrar fichero.");
		System.out.println("\t 0. Salir.");
	}

	// Crea el fichero
	private static void creFichero(File f) {

		try {
			if (f.createNewFile())
				System.out.println("El fichero " + f.getName() + "se ha creado\n");
			else
				System.out.println("El ficjero " + f.getName() + " no se ha creado\n");
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	// Mostrar informacion del fichero

	private static void infFichero(File iF) {
		System.out.print("\tNombre-> " + iF.getName() + "\n\tRuta absoluta-> " + iF.getAbsolutePath()
				+ "\n\tRuta relativa: " + iF.getPath() + "\n\tTamaño del fichero del fichero: " + iF.length() + "\n\n");
	}

	private static void longitud(File lF) {
		if (lF.exists())
			System.out.println("La longitud del fichero " + lF.getName() + " es de " + lF.length());
		else
			System.out.println("El fichero " + lF.getName() + " no existe.");
	}

	private static void existe(File eF) {
		if (eF.exists())
			System.out.println("El fichero " + eF.getName() + " existe.");
		else
			System.out.println("El fichero " + eF.getName() + " no existe.");
	}

	private static void borrar(File bF) {
		if (bF.exists())
			if (bF.delete())
				System.out.println("El fichero " + bF.getName() + " ha sido borrado.");
			else
				System.out.println("El fichero " + bF.getName() + " no ha sido borrado.");
		else
			System.out.println("El fichero " + bF.getName() + " no existe.");
	}

}
