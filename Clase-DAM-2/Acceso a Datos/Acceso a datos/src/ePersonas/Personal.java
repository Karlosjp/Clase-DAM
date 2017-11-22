package ePersonas;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

public class Personal {
	ArrayList<Persona> pers = new ArrayList<Persona>();

	public Personal() {
		pers.add(new Persona("Carlos", "Jaquez", 26));
		pers.add(new Persona("Pepe", "Jimenez", 30));
		pers.add(new Persona("Laura", "Marcos", 32));
		pers.add(new Persona("Luisa", "Fernandez", 20));
		pers.add(new Persona("Lenna", "Brerz", 26));
	}

	public void escribirFichero() {
		try {
			File fichero = new File("Personal.txt");
			if (!fichero.exists()) {
				FileWriter escribirFichero = new FileWriter(fichero);
				BufferedWriter escribirBuffer = new BufferedWriter(escribirFichero);

				for (int i = 0; i < pers.size(); i++) {
					escribirBuffer.write(pers.get(i).getNombre());
					escribirBuffer.newLine();
					escribirBuffer.write(pers.get(i).getApellido());
					escribirBuffer.newLine();
					escribirBuffer.write(String.valueOf(pers.get(i).getEdad()));
					escribirBuffer.newLine();
				}
				escribirBuffer.close();
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void leerFichero() {
		String listaPersonal;

		try {
			File fichero = new File("Personal.txt");

			if (fichero.exists()) {
				FileReader leerFichero = new FileReader(fichero);
				BufferedReader leerBuffer = new BufferedReader(leerFichero);

				String linea;
				linea = leerBuffer.readLine();
				int j = 0;

				while (linea != null) {
					pers.add(new Persona());

					pers.get(j).setNombre(linea);
					linea = leerBuffer.readLine();
					pers.get(j).setApellido(linea);
					linea = leerBuffer.readLine();
					pers.get(j).setEdad(Integer.parseInt(linea));
					linea = leerBuffer.readLine();

					j++;
				}
			} else
				System.out.println("El fichero " + fichero.getName() + " no existe.");

		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void escribirPantalla() {
		for (int i = 0; i < pers.size(); i++)
			System.out.println(pers.get(i).imprimir());
	}

	public void vaciar() {
		pers.clear();
	}

	public void anhadir(Persona p) {
		pers.add(p);
	}

	public void borrar(int p) {
		pers.remove(p);
	}
}
