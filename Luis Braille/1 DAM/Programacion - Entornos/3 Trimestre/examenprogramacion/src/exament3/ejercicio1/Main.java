package exament3.ejercicio1;

import java.util.ArrayList;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		ArrayList<Character> alPantalla = new ArrayList<Character>();
		final int HORIZ = 3, VERT = 6;

		for (int intCont = 0; intCont < HORIZ * VERT; intCont++) {
			alPantalla.add((char) Math.floor(Math.random() * (90 - 65) + 65));
		}

//		alPantalla.add('H');
//		alPantalla.add('L');
//		alPantalla.add('Y');
//		alPantalla.add('Y');
//		alPantalla.add('A');
//		alPantalla.add('H');
//		alPantalla.add('H');
//		alPantalla.add('J');
//		alPantalla.add('V');
//		alPantalla.add('V');
//		alPantalla.add('V');
//		alPantalla.add('H');
//		alPantalla.add('H');
//		alPantalla.add('J');
//		alPantalla.add('J');
//		alPantalla.add('J');
//		alPantalla.add('J');
//		alPantalla.add('H');

		System.out.println("\nPUNTUACIÓN " + puntuacion(alPantalla, HORIZ, VERT));
	}

	public static int puntuacion(List<Character> alPantalla, int intHoriz, int intVert) {

		// imprime el tablero
		for (int intI = 0; intI < alPantalla.size() / intVert; intI++) {
			for (int intY = 0; intY < intVert; intY++)
				System.out.print(alPantalla.get(intI * intVert + intY) + " ");

			System.out.println();
		}

		/*
		 * calcula puntuacion
		 */
		int intPuntuacionTotal = 0;

		// Calcula de forma horizontal
		for (int intI = 0; intI < alPantalla.size() / intVert; intI++) {
			char chCaracter = alPantalla.get(intI * intVert);
			int intPuntuacionTemporal = 1, intPuntuacion = 0;

			for (int intY = 0; intY < intVert; intY++) {
				int intPos = intI * intVert + intY;
				char chNuevoCaracter = alPantalla.get(intPos);

				if (intY > 0 && intY < intVert) {
					if (chCaracter == chNuevoCaracter && chCaracter != 'V')
						intPuntuacionTemporal++;

					if (intY == intVert - 1 && intPuntuacionTemporal >= 3) {
						if (intPuntuacionTemporal > 3)
							intPuntuacion += intPuntuacionTemporal - 2;
						else
							intPuntuacion++;

						intPuntuacionTemporal = 1;
					} else if (chCaracter != chNuevoCaracter) {
						if (intPuntuacionTemporal >= 3)
							if (intPuntuacionTemporal > 3)
								intPuntuacion += intPuntuacionTemporal - 2;
							else
								intPuntuacion++;

						intPuntuacionTemporal = 1;
					}
				}

				chCaracter = chNuevoCaracter;
			}

			intPuntuacionTotal += intPuntuacion;
		}

		// Calcula de forma vertical
		for (int intI = 0; intI < alPantalla.size() / intHoriz; intI++) {
			char chCaracter = alPantalla.get(intI);
			int intPuntuacionTemporal = 1, intPuntuacion = 0;

			for (int intY = 0; intY < alPantalla.size(); intY += alPantalla.size() / intHoriz) {
				int intPos = intY + intI;
				char chNuevoCaracter = alPantalla.get(intPos);

				if (intY != 0 && intY < alPantalla.size()) {
					if (chCaracter == chNuevoCaracter && chCaracter != 'V')
						intPuntuacionTemporal++;

					if (intY == alPantalla.size() - intVert && intPuntuacionTemporal >= 3) {
						if (intPuntuacionTemporal > 3)
							intPuntuacion += intPuntuacionTemporal - 2;
						else
							intPuntuacion++;
					} else if (chCaracter != chNuevoCaracter) {
						if (intPuntuacionTemporal >= 3)
							if (intPuntuacionTemporal > 3)
								intPuntuacion += intPuntuacionTemporal - 2;
							else
								intPuntuacion++;

						intPuntuacionTemporal = 1;
					}
				}

				chCaracter = chNuevoCaracter;
			}

			intPuntuacionTotal += intPuntuacion;
		}

		return intPuntuacionTotal;
	}

}
