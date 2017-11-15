package examen;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class GestionProductos {

	private String lista = "", nFichero;
	private String[] datos;
	private Producto[] prod = {new Producto(), new Producto(), new Producto(), new Producto()};

	// Metodos
	public void leerFichero(String nFichero) {
		try {
			File fichero = new File(nFichero);
			FileReader rFichero = new FileReader(fichero);

			char[] nombre = new char[1];

			while (rFichero.read(nombre) != -1) {
				lista += String.valueOf(nombre);
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public void separarProductos() {
		String[] lProd;

		lProd = lista.split(";");

		for (int i = 0; i < lProd.length; i++) {
			datos = lProd[i].split(":");
			for (int j = 0; j < datos.length; j++) {
				if (j % 2 == 0)
					prod[i].setNombre(datos[j]);
				else {
					prod[i].setPrecio(Double.valueOf(datos[j]));
				}
			}
		}
	}

	/*
	 * public void crearProductos() { int i = 0; for (int j = 0; j <
	 * datos.length; j++) { if (j % 2 == 0) prod[i].setNombre(datos[j]); else {
	 * prod[i].setPrecio(Double.valueOf(datos[j])); i++; } } }
	 */

	public void imprimir() {
		for (int i = 0; i < prod.length; i++)
			System.out.println(prod[i].escribir());
	}
}
