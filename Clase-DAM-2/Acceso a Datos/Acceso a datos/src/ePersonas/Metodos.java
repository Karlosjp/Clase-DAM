package ePersonas;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class Metodos {
	public void escribirFichero(Persona[] personas) {
		try {
			File fichero = new File("Personal.txt");
			FileWriter escribirFichero = new FileWriter(fichero);
			BufferedWriter escribirBuffer = new BufferedWriter(escribirFichero);

			for (int i = 0; i < personas.length; i++) {
				escribirBuffer.write(personas[i].getNombre());
				escribirBuffer.write(personas[i].getApellido());
				escribirBuffer.write(personas[i].getEdad());
				escribirBuffer.newLine();
			}

			escribirBuffer.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void leerFichero(Persona[] personas) {
		try {
			File fichero = new File("Personal.txt");
			FileReader leerfichero = new FileReader(fichero);
			BufferedReader leerBuffer = new BufferedReader(leerfichero);
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public void escribirPantalla(Persona[] personas) {
		for (int i = 0; i < personas.length; i++)
			personas[i].imprimir();
	}

	public void vaciar(Persona[] personas) {
		for (int i = 0; i < personas.length; i++)
			personas[i].vaciar();
	}
}
