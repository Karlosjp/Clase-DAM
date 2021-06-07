package exament3.ejercicio1v2;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		ArrayList<Character> alPantalla = new ArrayList<Character>();
		final int HORIZ = 3, VERT = 6;

//		for (int intCont = 0; intCont < HORIZ * VERT; intCont++) {
//			alPantalla.add((char) Math.floor(Math.random() * (90 - 65) + 65));
//		}

		alPantalla.add('H');
		alPantalla.add('A');
		alPantalla.add('Y');
		alPantalla.add('Y');
		alPantalla.add('A');
		alPantalla.add('H');
		alPantalla.add('H');
		alPantalla.add('J');
		alPantalla.add('V');
		alPantalla.add('V');
		alPantalla.add('V');
		alPantalla.add('H');
		alPantalla.add('H');
		alPantalla.add('J');
		alPantalla.add('J');
		alPantalla.add('J');
		alPantalla.add('J');
		alPantalla.add('H');

		for (int intI = 0; intI < alPantalla.size() / VERT; intI++) {
			for (int intY = 0; intY < VERT; intY++)
				System.out.print(alPantalla.get(intI * VERT + intY) + " ");

			System.out.println();
		}
		System.out.println("\nPUNTUACIÓN " + puntuarLetra(alPantalla, HORIZ, VERT, 'A'));
	}

	public static int puntuacion(List<Character> alPantalla, int intHoriz, int intVert) {

		return 0;
	}

	public static int puntuarLetra(List<Character> alPantalla, int intHoriz, int intVert, Character chLetra) {

		int indexOfLetra = alPantalla.indexOf(chLetra);
		int intInicioX = indexOfLetra / intVert;
		int intInicioY = indexOfLetra % intVert;
		int intPuntuacion = 0;

		for (int intX = intInicioX; intX < alPantalla.size() / intVert; intX++) {
			int intPuntuacionTemporal = 1;

			for (int intY = intInicioY + 1; intY < alPantalla.size() / intHoriz; intY++) {
				int intPos = intX * intVert + intY;
				if (alPantalla.get(intPos).equals(chLetra))
					intPuntuacionTemporal++;

				if (intY == intVert - 1 && intPuntuacionTemporal >= 3)
					intPuntuacion += intPuntuacionTemporal;
			}
		}

		return 0;
	}

}
