package asterisco;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int cantidad = 0;

		System.out.println("Escribe un numero para la piramide");
		cantidad = scn.nextInt();

		for (int i = 0; i < cantidad; i++) {
			int intCantidad0 = cantidad - i;
			for (int j = 0; j < cantidad; j++) {
				if (--intCantidad0 > 0) {
					System.out.print(" ");
				} else {
					System.out.print("*");
				}

			}
			System.out.println("");
		}

	}

}
