package Ejercicios_profesor.ejercicio6;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scnLeer = new Scanner(System.in);
		String strCadena;

		try {
			System.out.println("Dame un valor");

			strCadena = scnLeer.next();

			if (strCadena.length() == 1)
				throw new Exception("OK");
			else
				throw new Exception("NO");

		} catch (Exception e) {
			System.out.println(e.getMessage());
		}

	}

}
