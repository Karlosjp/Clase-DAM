package ejerciciosFecha;

public class NIF {
	private static final String NIF_STRING_ASOCIATION = "TRWAGMYFPDXBNJZSQVHLCKE";
	private int dni;
	private char letra;

	public int getDni() {
		return dni;
	}

	public void setDni(int dni) {
		this.dni = dni;
	}

	public char getLetra() {
		return letra;
	}

	public void setLetra(char letra) {
		this.letra = letra;
	}

	public static char calcularLetra(int dni) {
		return NIF_STRING_ASOCIATION.charAt(dni % 23);
	}

	private boolean comprobarLetra() {
		boolean cLetra = false;

		if (letra == calcularLetra(dni))
			cLetra = true;

		return cLetra;
	}
}
