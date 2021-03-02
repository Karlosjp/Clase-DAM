package Ejercicios_profesor.ejercicio5;

public class Main {

	public static void main(String[] args) {
		try {
			throw new DefinoExcepcion("Pruebo mi Excepción");
		} catch (DefinoExcepcion e) {
			System.out.println("Mensaje excepción: " + e.getMessage());
		}
	}

}
