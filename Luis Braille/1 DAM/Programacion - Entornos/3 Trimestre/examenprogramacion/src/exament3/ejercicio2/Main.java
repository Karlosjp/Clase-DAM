package exament3.ejercicio2;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		System.out.println("imprimo el fichero cargado");
		char[][] miMatriz = tableroToMatriz("miTablero.txt");
		imprimeArray(miMatriz);
	}

	public static char[][] tableroToMatriz(String miTablero) {

		List<String> liCaracteres = new ArrayList<String>();
		char[][] arrCaracteres = null;

		try {
			BufferedReader br = new BufferedReader(new FileReader(miTablero));
			String strLinea = "";

			while (strLinea != null) {
				strLinea = br.readLine();
				if (strLinea != null)
					liCaracteres.add(strLinea);
			}
			br.close();

		} catch (IOException e) {
			e.printStackTrace();
		}

		arrCaracteres = new char[liCaracteres.size()][];

		int intPos = 0;
		for (String string : liCaracteres)
			arrCaracteres[intPos++] = string.replaceAll(";", "").toCharArray();

		return arrCaracteres;
	}

	public static void imprimeArray(char[][] arrMiTablero) {
		for (char[] cs : arrMiTablero) {
			System.out.println(cs);
		}
	}
}
