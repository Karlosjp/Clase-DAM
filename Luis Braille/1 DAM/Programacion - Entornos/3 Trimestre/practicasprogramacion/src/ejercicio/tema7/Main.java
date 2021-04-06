package ejercicio.tema7;

import java.util.Iterator;
import java.util.Scanner;

public class Main {

	/**
	 * Dada una cadena cad, y un caracter car, verificar cuántas veces se repite el
	 * carácter car en la cadena cad, por ejemplo: Entrada: cad = "casa blanca", car
	 * = 'a' Salida: El caracter 'a' se repite 4 veces adf
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner scnLeer = new Scanner(System.in);
		int intSeleccion = 0;

		do {
			System.out.println("Selecciona ejercicio (1-9): ");
			System.out.println("0 para terminar");
			intSeleccion = scnLeer.nextInt();

			switch (intSeleccion) {
			case 0:
				System.out.println("Terminando.");
				break;
			case 1:
				ej1();
				break;
			case 2:
				ej2();
				break;
			case 3:
				System.out.println("Trabajando.");
				break;
			case 4:
				System.out.println("Trabajando.");
				break;
			case 5:
				System.out.println("Trabajando.");
				break;
			case 6:
				System.out.println("Trabajando.");
				break;
			case 7:
				System.out.println("Trabajando.");
				break;
			case 8:
				System.out.println("Trabajando.");
				break;
			case 9:
				System.out.println("Trabajando.");
				break;
			default:
				System.out.println("Ejercicio no existe.");
			}

		} while (intSeleccion > 0);
	}

	private static void ej1() {
		Scanner scnLeer = new Scanner(System.in);
		int LINEAS = 3; // Número de líneas del texto
		String[] arrStrLineas = new String[LINEAS];

		int intTamano = 0;

		for (int intCont = 0; intCont < LINEAS; intCont++) {
			System.out.println("dame la cadena " + (intCont + 1));
			arrStrLineas[intCont] = scnLeer.nextLine();
			if (arrStrLineas[intCont].length() > intTamano) // guarda el array más largo
				intTamano = arrStrLineas[intCont].length();
		}

		System.out.println("Imprimo cadenas tal cual");

		for (String strCadena : arrStrLineas) {
			System.out.println(strCadena + "*");
		}

		// añado los espacios en blanco a cada cadena
		for (int intCont = 0; intCont < LINEAS; intCont++) {
			if (arrStrLineas[intCont].length() < intTamano)
				arrStrLineas[intCont] = arrStrLineas[intCont] + relleno(arrStrLineas[intCont].length(), intTamano);
		}

		System.out.println("Imprimo cadenas igualadas");

		for (String strCadena : arrStrLineas) {
			System.out.println(strCadena + "*");
		}
	}

	private static String relleno(int intTamLinea, int intTamMax) {
		String strCadena = "";

		for (int intCont = 0; intCont < intTamMax - intTamLinea; intCont++)
			strCadena = strCadena + " ";

		return strCadena;
	}

	private static void ej2() {
		Scanner scnLeer = new Scanner(System.in);
		String cadenas[] = new String[2];
		char caracteres[][] = new char[30][2];

		System.out.println("Escribir cadena 1");
		cadenas[0] = scnLeer.nextLine();
		System.out.println("Escribir cadena 2");
		cadenas[1] = scnLeer.nextLine();

		for (String strCadena : cadenas) {
			for (int intI = 0; intI < caracteres.length; intI++) {
				for (int intJ = 0; intJ < caracteres.length; intJ++) {

				}
				cadenas[0].charAt(intI);
			}
		}
//		for (char caracter : cadenas[0].toCharArray()) {
//			
//			System.out.println(caracter);
//		}
	}
	
	private static char[][] contarCaracteres(String cadena, char[][] caracteres){
		
		for (char caracter : cadena.toCharArray()) {
			for (int intI = 0; intI < caracteres.length; intI++) {
				if(caracteres[intI][0] == caracter)
					caracteres[intI][1]++;
			}
		}
		
		return caracteres;
	}
	
	private static String[][] caracteres(String cadena) {
		for(char caracter : cadena.toCharArray())
		return null;
	}
}
