package ejercicio.ahoracado;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Ahorcado juego = new Ahorcado("patata");
		Scanner scn = new Scanner(System.in);
		
		do {
			System.out.println("Escribe una letra");
			String charAux = scn.next();
			
			System.out.println(juego.comprobarLetra(charAux));
			
		} while (!juego.terminar());

		System.out.println("Juego terminado");
	}

}
