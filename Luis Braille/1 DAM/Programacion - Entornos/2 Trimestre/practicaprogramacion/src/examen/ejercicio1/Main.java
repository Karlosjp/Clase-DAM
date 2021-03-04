package examen.ejercicio1;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int intPuntuacion = 0;
		int[] arrPuntuaciones = new int[200];
		int[][] arrFrecuencia = { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };

		for (int intI = 0; intI < 200; intI++) {
			System.out.println("Puntua 200 veces entre 0 y 5");
			System.out.print("Numero: " + (intI + 1) + " ");
			intPuntuacion = scanner.nextInt();

			if (intPuntuacion >= 0 && intPuntuacion <= 5) {
				arrPuntuaciones[intI] = intPuntuacion;

				for (int intY = 0; intY < arrFrecuencia.length; intY++) {
					if (arrFrecuencia[intY][0] == intPuntuacion)
						arrFrecuencia[intY][1]++;
				}
			} else if (intPuntuacion < 0)
				intI = 0;
			else
				intI--;
		}

		for (int intI = 0; intI < arrFrecuencia.length; intI++) {
			System.out.println("Numero " + arrFrecuencia[intI][0] + ": " + arrFrecuencia[intI][1] + " veces");
		}
	}

}
