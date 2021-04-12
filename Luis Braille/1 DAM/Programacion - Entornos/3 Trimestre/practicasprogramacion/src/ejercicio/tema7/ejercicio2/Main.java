package ejercicio.tema7.ejercicio2;

import java.util.Scanner;

public class Main {

	/**
	 * Escribir un programa que encuentre dos cadenas introducidas por teclado que
	 * sean anagramas. Se considera que dos cadenas son anagramas si contienen
	 * exactamente los mismos caracteres, ya sea en el mismo o en diferente orden:
	 * ignorar los blancos y considerar que mayúsculas y minúsculas son iguales.
	 */
	public static void main(String[] args) {
		Scanner scnLeer = new Scanner(System.in);

		String lineas[] = new String[10];

		int intContador = 0;
		String strContinuar = "s";

		do {
			System.out.println("Escribir cadena " + (intContador + 1));
			lineas[intContador] = scnLeer.nextLine();

			intContador++;

			System.out.println("Continuar? (n) Salir, (s): Continuar");

		} while (!scnLeer.nextLine().toLowerCase().equals("n"));

		esAnagrama(lineas);
	}

	private static void esAnagrama(String[] lineas) {
		int intCaracteres[] = new int[28];
		int intCaracteresAux[] = new int[28];

		for (int intI = 0; intI < lineas.length; intI++) {
			if (lineas[intI] == null)
				continue;

			intCaracteres = contarCaracteres(lineas[intI]);

			for (int intY = 0; intY < lineas.length; intY++) {
				boolean booAnagrama = true;

				if (lineas[intY] == null)
					continue;

				if (intY != intI) {
					intCaracteresAux = contarCaracteres(lineas[intY]);

					for (int intX = 0; intX < intCaracteres.length; intX++)
						if (intCaracteres[intX] != intCaracteresAux[intX]) {
							booAnagrama = false;
							break;
						}

					if (booAnagrama) {
						System.out.println(
								"La cadena: " + lineas[intI] + " y la cadena: " + lineas[intY] + " Son un anagrama");
						lineas[intY] = null;
					}
				}
			}

			lineas[intI] = null;
		}
	}

	private static int[] contarCaracteres(String cadena) {
		final char arrChar[] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', '±', 'o', 'p',
				'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
		int arrayInt1[] = new int[28];

		for (int intI = 0; intI < arrChar.length; intI++) {

			for (char caracter : cadena.toCharArray())
				if (arrChar[intI] == caracter)
					arrayInt1[intI]++;
		}

		return arrayInt1;
	}
}
