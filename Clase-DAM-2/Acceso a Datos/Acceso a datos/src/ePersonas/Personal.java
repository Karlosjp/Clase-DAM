package ePersonas;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

public class Personal {

	private Persona[] personas = {new Persona("Carlos", "Jaquez", 26), new Persona("Pepe", "Jimenez", 30),
			new Persona("Laura", "Marcos", 32), new Persona("Luisa", "Fernandez", 20),
			new Persona("Lenna", "Brerz", 26)};

	public Personal() {
	}

	public void escribirFichero() {
		try {
			File fichero = new File("Personal.txt");
			if (!fichero.exists()) {
				FileWriter escribirFichero = new FileWriter(fichero);
				BufferedWriter escribirBuffer = new BufferedWriter(escribirFichero);

				for (int i = 0; i < personas.length; i++) {
					escribirBuffer.write(personas[i].getNombre());
					escribirBuffer.newLine();
					escribirBuffer.write(personas[i].getApellido());
					escribirBuffer.newLine();
					escribirBuffer.write(String.valueOf(personas[i].getEdad()));
					escribirBuffer.newLine();
				}
				escribirBuffer.close();
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void leerFichero() {
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

				for (int i = 0; i < personas.length; i++) {
					personas[i].setNombre(listaPersonal.get(j++));
					personas[i].setApellido(listaPersonal.get(j++));
					personas[i].setEdad(Integer.parseInt(listaPersonal.get(j++)));
				}
			} else
				System.out.println("El fichero " + fichero.getName() + " no existe.");

		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void escribirPantalla() {
		for (int i = 0; i < personas.length; i++)
			System.out.println(personas[i].imprimir());
	}

	public void vaciar() {
		for (int i = 0; i < personas.length; i++)
			personas[i].vaciar();
	}

	public void borrar() {

	}
}
