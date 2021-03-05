package examen.ejercicio1;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int intPuntuacion = 0;
		int[] arrFrecuencia = { 0, 0, 0, 0, 0, 0 };

		for (int intI = 0; intI < 200; intI++) {
			System.out.println("Puntua 200 veces entre 0 y 5");
			System.out.print("Numero: " + (intI + 1) + " ");
			intPuntuacion = scanner.nextInt();

			if (intPuntuacion >= 0 && intPuntuacion <= 5) {
				arrFrecuencia[intPuntuacion]++;
			} else
				intI--;

			if (intI < 0)
				intI = 0;
		}

		for (int intI = 0; intI < arrFrecuencia.length; intI++) {
			System.out.println("Numero " + intI + ": " + arrFrecuencia[intI] + " veces");
		}
	}

}
