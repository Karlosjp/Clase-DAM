package ejercicio.tema7.ejercicio1;

import java.util.Scanner;

public class Main {
	
	/**
	 * Un texto está formado por líneas de longitud variable con 80 caracteres como
	 * máximo. Se quiere que todas tengan la misma longitud que la de la cadena más
	 * larga; para ello se deben cargar con blancos por la derecha hasta completar
	 * la longitud requerida. Escribir un programa para leer un texto de líneas de
	 * longitud variable y formatear el texto para que todas tengan la longitud de
	 * la línea mayor.
	 */
	public static void main(String[] args) {
		Scanner scnLeer = new Scanner(System.in);
		int LINEAS = 3; // Nï¿½mero de lï¿½neas del texto
		String[] arrStrLineas = new String[LINEAS];

		int intTamano = 0;

		for (int intCont = 0; intCont < LINEAS; intCont++) {
			System.out.println("dame la cadena " + (intCont + 1));
			arrStrLineas[intCont] = scnLeer.nextLine();
			if (arrStrLineas[intCont].length() > intTamano) // guarda el array mï¿½s largo
				intTamano = arrStrLineas[intCont].length();
		}

		System.out.println("Imprimo cadenas tal cual");
		
		for (String strCadena : arrStrLineas) 
			System.out.println(strCadena + "*");
		

		// aï¿½ado los espacios en blanco a cada cadena
		for (int intCont = 0; intCont < LINEAS; intCont++) 
			if (arrStrLineas[intCont].length() < intTamano)
				arrStrLineas[intCont] = arrStrLineas[intCont] + relleno(arrStrLineas[intCont].length(), intTamano);	

		System.out.println("Imprimo cadenas igualadas");

		for (String strCadena : arrStrLineas) 
			System.out.println(strCadena + "*");
		}

	private static String relleno(int intTamLinea, int intTamMax) {
		String strCadena = "";

		for (int intCont = 0; intCont < intTamMax - intTamLinea; intCont++)
			strCadena = strCadena + " ";

		return strCadena;
	}

}
