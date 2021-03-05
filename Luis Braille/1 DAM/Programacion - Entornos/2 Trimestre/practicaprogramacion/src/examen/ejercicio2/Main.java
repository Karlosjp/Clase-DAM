package examen.ejercicio2;

public class Main {

	public static void main(String[] args) {
		try {
			Persona objPersona = new Persona("5214598E");
		} catch (DNIExepcion e) {
			System.out.println( "DNI 9 dígitos");
		}
	}
}
