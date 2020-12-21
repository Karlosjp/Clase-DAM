package ajustar2;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		int intLineas;
		Scanner scnLeer = new Scanner(System.in);

		System.out.println("Número de líneas a escribir:");
		intLineas = scnLeer.nextInt();
		
		//paso por las líneas
		for(int intCont=1; intCont<=intLineas; intCont++) {
			//imprimo los espacios en blanco
			for(int intBlancos=intLineas-intCont; intBlancos>0; intBlancos--) {
				System.out.print(' ');
			}
			//imprimo los *
			for(int intAsteriscos=intCont; intAsteriscos>0; intAsteriscos--) {
				System.out.print('*');
			}
			System.out.println("");
			
		}
	}

}
