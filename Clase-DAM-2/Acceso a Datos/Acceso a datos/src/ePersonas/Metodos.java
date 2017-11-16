package ePersonas;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

public class Metodos {

	public void escribirFichero(Persona[] personal) {
		try {
			File fichero = new File("Personal.txt");
			if (!fichero.exists()) {
				FileWriter escribirFichero = new FileWriter(fichero);
				BufferedWriter escribirBuffer = new BufferedWriter(escribirFichero);

				for (int i = 0; i < personal.length; i++) {
					escribirBuffer.write(personal[i].getNombre());
					escribirBuffer.newLine();
					escribirBuffer.write(personal[i].getApellido());
					escribirBuffer.newLine();
					escribirBuffer.write(String.valueOf(personal[i].getEdad()));
					escribirBuffer.newLine();
				}
				escribirBuffer.close();
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void leerFichero(Persona[] personal) {
		ArrayList<String> listaPersonal = new ArrayList<String>();

		try {
			File fichero = new File("Personal.txt");

			if (fichero.exists()) {
				FileReader leerFichero = new FileReader(fichero);
				BufferedReader leerBuffer = new BufferedReader(leerFichero);

				String linea;
				linea = leerBuffer.readLine();
				int j = 0;

				while (linea != null) {
					listaPersonal.add(linea);
					linea = leerBuffer.readLine();
				}

				for (int i = 0; i < personal.length; i++) {
					personal[i].setNombre(listaPersonal.get(j++));
					personal[i].setApellido(listaPersonal.get(j++));
					personal[i].setEdad(Integer.parseInt(listaPersonal.get(j++)));
				}
			} else
				System.out.println("El fichero " + fichero.getName() + " no existe.");

		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void escribirPantalla(Persona[] personas) {
		for (int i = 0; i < personas.length; i++)
			System.out.println(personas[i].imprimir());
	}

	public void vaciar(Persona[] personas) {
		for (int i = 0; i < personas.length; i++)
			personas[i].vaciar();
	}
}
