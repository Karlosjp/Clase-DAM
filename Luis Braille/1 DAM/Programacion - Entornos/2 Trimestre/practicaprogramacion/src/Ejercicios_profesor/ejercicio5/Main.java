package Ejercicios_profesor.ejercicio5;

public class Main {

	public static void main(String[] args) {
		try {
			throw new DefinoExcepcion("Pruebo mi Excepci�n");
		} catch (DefinoExcepcion e) {
			System.out.println("Mensaje excepci�n: " + e.getMessage());
		}
	}

}
