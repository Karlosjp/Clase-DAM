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

		Personal met = new Personal();
		Scanner scan = new Scanner(System.in);

		int opcion = 0;

		do {
			menu();

			opcion = scan.nextInt();

			switch (opcion) {
				case 1 :
					met.escribirFichero();
					break;
				case 2 :
					met.leerFichero();
					break;
				case 3 :
					met.escribirPantalla();
					break;
				case 4 :
					met.vaciar();
					break;
				default :
					break;
			}
		} while (opcion != 0);
	}

}
