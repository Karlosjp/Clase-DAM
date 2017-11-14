package ficheros;

import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FicherosTextos1 {

	public static void escribirFichero(String[] lista) {
		try {
			// 1. Crear fichero.
			File fichero = new File("FicheroNombres.txt");
			FileWriter ficheroEscritura = new FileWriter(fichero);

			// 2. Escribir nombres.
			for (int i = 0; i < lista.length; i++) {
				ficheroEscritura.write(lista[i] + ":");
			}

			// 3. Cerrar fichero.
			ficheroEscritura.close();

		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	public static void leerFicero(String[] lista) {
		try {
			// 1. Crear fichero.
			File fichero = new File("FicheroNombres.txt");
			FileReader ficheroLectura = new FileReader(fichero);

			// 2. Leer nombres.
			char[] nombre = new char[5];
			int res, i = 0;

			while (ficheroLectura.read(nombre) != -1) {

				lista[i] = String.valueOf(nombre);

				i++;
			}

			// 3. Cerrar fichero.
			ficheroLectura.close();

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
		String[] lista = {"Pepe", "Ana", "Juan"};

		escribirFichero(lista);

		for (int i = 0; i < lista.length; i++)
			lista[i] = "";

		leerFicero(lista);

		imprimirTabla(lista);

	}

}
