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
		System.out.println("\t5. Modificar datos");
		System.out.println("\t6. Borrar una persona");
		System.out.println("\t7. Añadir datos");

	}

	public static void main(String[] args) {

		Personal personal = new Personal();
		Scanner scan = new Scanner(System.in);

		int opcion = 0;

		do {
			menu();

			opcion = scan.nextInt();

			switch (opcion) {
				case 1 :
					personal.escribirFichero();
					break;
				case 2 :
					personal.leerFichero();
					break;
				case 3 :
					personal.escribirPantalla();
					break;
				case 4 :
					personal.vaciar();
					break;
				default :
					break;
			}
		} while (opcion != 0);
	}

}
