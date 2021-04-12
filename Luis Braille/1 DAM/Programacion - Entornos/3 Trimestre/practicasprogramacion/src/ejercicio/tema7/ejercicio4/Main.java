package ejercicio.tema7.ejercicio4;

import java.util.Scanner;

public class Main {

	/**
	 * Escribir un programa que lea l�neas de texto, obtenga las palabras de cada una
	 * y las imprima en orden alfab�tico; considerar que el n�mero m�ximo de
	 * palabras por l�nea es 28.
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner scnLeer = new Scanner(System.in);
		String strLineas [] = new String[10];
		int intLinea = 0;
		
		do {
			System.out.println("Escribe la linea " + intLinea);
			strLineas[intLinea] = scnLeer.nextLine();
			
			String strPalabras[] = strLineas[intLinea].split(" ");
			
			if(strPalabras.length > 28)
				strLineas[intLinea] = "";
			else
				intLinea++;
			
		} while (intLinea < strLineas.length);
	}
}
