package buffereader;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class FicherosTextoBuffered {

	public static void escribirFichero(String[] lista) {
		try {
			// 1. Crear fichero.
			File fichero = new File("FicheroBuffered.txt");
			FileWriter ficheroEscritura = new FileWriter(fichero);
			BufferedWriter ficheroBuffer = new BufferedWriter(ficheroEscritura);

			// 2. Escribir nombres.
			for (int i = 0; i < lista.length; i++) {
				ficheroBuffer.write(lista[i]);
				ficheroBuffer.newLine();
			}

			// 3. Cerrar fichero.
			ficheroBuffer.close();

		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	public static void leerFicero(String[] lista) {
		try {
			// 1. Crear fichero.
			File fichero = new File("FicheroBuffered.txt");
			FileReader ficheroLectura = new FileReader(fichero);
			BufferedReader ficheroBuffer = new BufferedReader(ficheroLectura);

			// 2. Leer nombres con string, cuando read devuelve un null se ha
			// llegado al final del fichero.
			String linea;
			int i = 0;
			linea = ficheroBuffer.readLine();

			while (linea != null) {
				lista[i] = linea;
				i++;
				linea = ficheroBuffer.readLine();
			}

			// 3. Cerrar fichero.
			ficheroBuffer.close();

		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public static void imprimirTabla(String[] lista) {

		for (int i = 0; i < lista.length; i++) {
			System.out.println("Posicion " + i + ": " + lista[i]);
		}
	}

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		String[] lista = {"Pepe", "Ana", "Juan"};

		int opcion = 0;

		do {
			System.out.println("Escribe opcion 1 2 3");
			opcion = scan.nextInt();

			switch (opcion) {
				case 1 :
					escribirFichero(lista);
					for (int i = 0; i < lista.length; i++)
						lista[i] = "";
					break;
				case 2 :
					leerFicero(lista);
					break;
				case 3 :
					imprimirTabla(lista);
					break;
				default :
					break;
			}
		} while (opcion != 0);
	}
}
