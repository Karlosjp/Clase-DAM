package ejercicio.ahoracado;

public class Ahorcado {
	private final int ERRORES = 3;
	private final String STRCORRECTO = "Letra correcta", STRINCORRECTO = "Letra incorrecta",
			STRREPETIDO = "Letra repetida";

	private String strPalabra, strLetras;
	private int intErrores;

	public Ahorcado(String strPalabra) {

		this.strPalabra = strPalabra.toLowerCase();
		this.intErrores = ERRORES;
		this.strLetras = "";
	}

	public String comprobarLetra(String strLetra) {
		strLetra = strLetra.toLowerCase();

		if (!letrasRepetidas(strLetra)) {
			for (int intI = 0; intI < strPalabra.length(); intI++) {
				if (strPalabra.charAt(intI) == strLetra.charAt(0))
					return STRCORRECTO;
			}

			actualizarIntentos();

			return STRINCORRECTO;
		}

		return STRREPETIDO;
	}

	public boolean terminar() {
		return intErrores == 0;
	}

	private void actualizarIntentos() {
		intErrores--;
	}

	private boolean letrasRepetidas(String strLetra) {
		for (int intI = 0; intI < strLetras.length(); intI++) {
			if (strLetras.charAt(intI) == strLetra.charAt(0)) {
				this.strLetras += strLetra;
				return true;
			}
		}

		this.strLetras += strLetra;
		return false;
	}
}
