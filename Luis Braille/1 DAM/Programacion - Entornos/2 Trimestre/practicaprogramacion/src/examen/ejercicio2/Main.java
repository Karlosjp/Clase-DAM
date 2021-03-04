package examen.ejercicio2;

public class Main {

	public static void main(String[] args) {
		try {
			Persona objPersona = new Persona("5214598E");
		} catch (DNIExepcion e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
