package ejercicio.ejchar;

import java.util.Scanner;

public class Main {
	Scanner scn = new Scanner(System.in);

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);

		System.out.println("Escribe texto");
		String strPalabra = scn.nextLine().toLowerCase();

		System.out.println("Que ejercicio quieres?");
		System.out.println("*- 1");
		System.out.println("*- 2");
		System.out.println("*- 3");

		int intEj = scn.nextInt();

		switch (intEj) {
		case 1:
			ej1Char(strPalabra);
			break;
		case 2:
			ej2Char(strPalabra);
			break;
		case 3:
			System.out.println("Que caracter buscas?: ");
			ej3Char(strPalabra, scn.next().charAt(0));
			break;
		default:
			System.out.println("Ejercicio no encontrado");
		}
	}

	/**
	 * Dada una cadena mostrar por pantalla la cantidad de vocales que tiene.
	 * Ejemplo: Entrada: cad = "Hola tu" Salida: La cantidad de vocales es 3.
	 * 
	 * @param strPalabra
	 */

	public static void ej1Char(String strPalabra) {
		final char[] CHARVOCALES = { 'a', 'e', 'i', 'o', 'u' };
		int intVocales = 0;

		for (int intI = 0; intI < strPalabra.length(); intI++) {
			for (int intJ = 0; intJ < CHARVOCALES.length; intJ++) {
				if (strPalabra.charAt(intI) == CHARVOCALES[intJ])
					intVocales++;
			}
		}

		System.out.println("La palabra " + strPalabra + " tiene " + intVocales + " vocales.");
	}

	/**
	 * Dada una cadena invertir la misma y mostrar por pantalla. Ejemplo: Entrada:
	 * "casa blanca" Salida: "acnalb asac".
	 * 
	 * @param strPalabra
	 */
	public static void ej2Char(String strPalabra) {
		String strInvertida = "";

		for (int intI = strPalabra.length(); intI > 0;) {
			strInvertida += strPalabra.charAt(--intI);
		}

		System.out.println(strPalabra + " invertido queda: " + strInvertida);
	}

	/**
	 * Dada una cadena cad, y un caracter car, verificar cuántas veces se repite el
	 * carácter car en la cadena cad, por ejemplo: Entrada: cad = "casa blanca", car
	 * = 'a' Salida: El caracter 'a' se repite 4 veces.
	 * 
	 * @param strPalabra
	 * @param charC
	 */
	public static void ej3Char(String strPalabra, char charC) {
		int intContadorLetra = 0;

		for (int intI = 0; intI < strPalabra.length(); intI++) {
			if (strPalabra.charAt(intI) == charC)
				intContadorLetra++;
		}

		System.out.println("En la palabra: " + strPalabra + " el caracter " + charC + " se repite: " + intContadorLetra
				+ " veces");
	}
}
