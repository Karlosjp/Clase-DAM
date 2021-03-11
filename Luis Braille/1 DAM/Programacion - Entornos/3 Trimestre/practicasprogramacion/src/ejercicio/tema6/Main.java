package ejercicio.tema6;

import java.util.Iterator;
import java.util.Scanner;

public class Main {
	
	/**
	 * Dada una cadena cad, y un caracter car, verificar cuántas veces se repite el carácter car en la cadena cad, por ejemplo:
	 * Entrada: cad = "casa blanca", car = 'a'
	 * Salida: El caracter 'a' se repite 4 veces
	 * adf
	 * @param args
	 */

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		final int INTLINEAS = 15;
		String[] strTexto = new String[INTLINEAS];
		String strLinea = "", strTerminar = "-1";
		int intLineas = 0;

		do {
			System.out.println("Escribe la " + (intLineas + 1) + " linea de texto");
			strLinea = scn.nextLine();
			if (strLinea.equals(strTerminar))
				break;
			
			strTexto[intLineas++] = strLinea;
			
		} while (intLineas < strTexto.length);
		
		for (int intI = 0; intI < strTexto.length && strTexto[intI] != null; intI++) {
			if (strTexto[intI].length() < 80) {
				for (int intJ = 0; strTexto[intI].length() < 79; intJ++) {
					strTexto[intI] += new String(" ");
				}
				
				strTexto[intI] += ",";
			}
		}

		for (String string : strTexto) {
			if (string != null) 
				System.out.println(string);
		}
	}
}
