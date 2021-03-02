package Ejercicios_profesor.ejercicio4;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scnLeer = null;

		try {
			scnLeer.next();
		} catch (NullPointerException npe) {
			System.out.println("Objeto no definido");
		}
	}

}
