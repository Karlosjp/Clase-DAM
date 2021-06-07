package solucion;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Main {

	public static void main(String[] args) {
		ArrayList<Character> alPantalla = new ArrayList<Character>();
		final int HORIZ = 3, VERT = 6; // tamaño de la matriz

		for (int intCont = 0; intCont < HORIZ * VERT; intCont++) // añado letras a mi matriz
			alPantalla.add((char) Math.floor(Math.random() * (90 - 65) + 65));

		System.out.println("\nPUNTUACIÓN " + puntuacion(alPantalla, HORIZ, VERT));// imprimo la puntuación

		// Ejercicio 2
		System.out.println("\nimprimo el fichero cargado");
		char[][] miMatriz = tableroToMatriz("miTablero.txt");
		
		imprimeArray(miMatriz);

		// Ejercicio 3
		highScore(200);
	}

	private static void highScore(int intPuntos) {
		Connection conexion = null;
		int intAux = 0;
		boolean blnInsertar = false;
		Scanner scnLeer = new Scanner(System.in);

		try {
			conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");// se establece
																										// la conexión
			Statement instruccion = conexion.createStatement();
			ResultSet rs = instruccion.executeQuery("Select count(*) from examen");

			if (rs.next())// guardo cuantos registros hay en la tabla
				intAux = rs.getInt(1);
			if (intAux >= 5) {// si hay 20, miro si es mayor que el último
				intAux = 0;
				rs = instruccion.executeQuery("Select count(*) from examen where puntuacion<" + intPuntos);

				if (rs.next())
					intAux = rs.getInt(1);

				if (intAux > 0) {// si hay alguno menor que yo lo borro
					rs = instruccion.executeQuery(
							"SELECT ID FROM examen WHERE PUNTUACION<" + intPuntos + " order by PUNTUACION");

					if (rs.next())// cojo el primer menor
						intAux = rs.getInt(1);

					instruccion.executeUpdate("delete from examen where id=" + intAux);

					blnInsertar = true;
				}
			} else
				blnInsertar = true;

			if (blnInsertar == true) {
				System.out.println("Dame tu nombre");
				String strNombre = scnLeer.nextLine();
				System.out.println("Dame la fecha");
				String strFecha = scnLeer.nextLine();

				instruccion.executeUpdate("insert into examen(nombre,fecha,puntuacion) values('" + strNombre + "','"
						+ strFecha + "'," + intPuntos + ')');
			}
		} catch (SQLException e) {
			System.out.println("Error en la conexión con la BD");
		}
	}

	private static char[][] tableroToMatriz(String strFichero) {
		String strCadena;
		StringTokenizer st;
		int intFila = 0;
		ArrayList<Character> alMatriz = new ArrayList<Character>();
		char[][] arrCharPantalla = null;

		try {// cargo todo en el arraylist y veo cuantas filas tiene
			BufferedReader br = new BufferedReader(new FileReader(strFichero));

			while ((strCadena = br.readLine()) != null) {
				intFila++;

				st = new StringTokenizer(strCadena, ";");

				while (st.hasMoreTokens())
					alMatriz.add(st.nextToken().charAt(0));
			}

			br.close();
		} catch (FileNotFoundException fnfe) {
			System.out.println("No existe el fichero");
		} catch (IOException e) {
		}

		if (intFila > 0) {
			arrCharPantalla = new char[intFila][(alMatriz.size()) / intFila];

			for (int intFil = 0, intPos = 0; intFil < intFila; intFil++)
				for (int intCol = 0; intCol < arrCharPantalla[0].length; intCol++, intPos++)
					arrCharPantalla[intFil][intCol] = alMatriz.get(intPos);
		}

		return arrCharPantalla;
	}

	public static int puntuacion(ArrayList<Character> alPantalla, int intHoriz, int intVert) {
		int intPuntos = 0;
		char[][] chrPantalla = new char[intHoriz][intVert];

		if (alPantalla.size() < intHoriz * intVert)
			System.out.println("El arrayList no coincide con el tamaño de pantalla indicado");
		else { // meto todo el contenido del arraylist en un array bidimensional
			for (int intH = 0, intPos = 0; intH < intHoriz; intH++)
				for (int intV = 0; intV < intVert; intV++, intPos++)
					chrPantalla[intH][intV] = alPantalla.get(intPos);

			for (int intV = 1; intV < 5; intV++)
				chrPantalla[2][intV] = 'J';

			chrPantalla[1][1] = 'J';
			chrPantalla[1][3] = 'J';

			// imprimo la matriz
			imprimeArray(chrPantalla);

			// llamo elemento por elemento del array y voy sumando puntuaciones
			for (int intH = 0, intParcial = 0; intH < intHoriz; intH++) {
				for (int intV = 0; intV < intVert; intV++) {
					char chrCaracter = chrPantalla[intH][intV];
					chrPantalla[intH][intV] = 'V';

					if (intV + 1 < chrPantalla[0].length)
						intParcial += cuenta(intH, intV + 1, chrPantalla, chrCaracter);

					if (intH + 1 < chrPantalla.length)
						intParcial += cuenta(intH + 1, intV, chrPantalla, chrCaracter);

					if (intParcial > 2)
						intPuntos += intParcial - 1;

					intParcial = 0;
				}
			}
		}

		return intPuntos;
	}

	private static void imprimeArray(char[][] chrPantalla) {
		if (chrPantalla != null) {
			for (int intX = 0; intX < chrPantalla.length; intX++) {
				for (int intY = 0; intY < chrPantalla[0].length; intY++)
					System.out.print(chrPantalla[intX][intY] + " ");

				System.out.println();
			}
		}
	}

	private static int cuenta(int intH, int intV, char[][] chrPantalla, char chrCaracter) {
		int intCuenta = 0;

		// si no es un hueco y es el mismo caracter del anterior buscamos en todos los
		// adyacentes
		// y pongo como vacío ese caracter pq ya lo hemos contado
		if (chrPantalla[intH][intV] != 'V' && chrPantalla[intH][intV] == chrCaracter) {
			intCuenta = 1;
			chrPantalla[intH][intV] = 'V';

			if (intV - 1 >= 0)
				intCuenta += cuenta(intH, intV - 1, chrPantalla, chrCaracter);

			if (intH - 1 >= 0)
				intCuenta += cuenta(intH - 1, intV, chrPantalla, chrCaracter);

			if (intV + 1 < chrPantalla[0].length)
				intCuenta += cuenta(intH, intV + 1, chrPantalla, chrCaracter);

			if (intH + 1 < chrPantalla.length)
				intCuenta += cuenta(intH + 1, intV, chrPantalla, chrCaracter);
		}

		return intCuenta;
	}

}
