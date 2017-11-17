package ePersonas;

import java.util.Scanner;

public class MainPersona {
	public static void menu() {
		System.out.println("Menu gesion de personas");
		System.out.println("Elije una opcion");
		System.out.println("\t1. Guardar en un fichero");
		System.out.println("\t2. Abrir desde un fichero");
		System.out.println("\t3. Imprimir datos");
		System.out.println("\t4. Borrar datos");
	}

	public static void main(String[] args) {
		Persona[] personas = {new Persona("Carlos", "Jaquez", 26), new Persona("Pepe", "Jimenez", 30),
				new Persona("Laura", "Marcos", 32), new Persona("Luisa", "Fernandez", 20),
				new Persona("Lenna", "Brerz", 26)};

		Metodos met = new Metodos();
		Scanner scan = new Scanner(System.in);

		int opcion = 0;

		do {
			menu();

			opcion = scan.nextInt();

			switch (opcion) {
				case 1 :
					met.escribirFichero(personas);
					break;
				case 2 :
					met.leerFichero(personas);
					break;
				case 3 :
					met.escribirPantalla(personas);
					break;
				case 4 :
					met.vaciar(personas);
					break;
				default :
					break;
			}
		} while (opcion != 0);

	}

}