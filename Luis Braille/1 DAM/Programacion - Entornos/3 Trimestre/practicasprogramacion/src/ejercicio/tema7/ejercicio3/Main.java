package ejercicio.tema7.ejercicio3;

public class Main {

	/**
	 * Se sabe que en las l�neas de un texto hay valores num�ricos enteros que
	 * representan los kilogramos de patatas recogidos en una finca; dichos valores
	 * est�n separados de las palabras por un blanco, o el car�cter fin de l�nea.
	 * Escribir un programa que lea el texto y obtenga la suma de los valores
	 * num�ricos.
	 */
	public static void main(String[] args) {
		String strCadena = "2 que tal 5 estamos 7 hoy";
		String strAux;
		int intFinal;
		int intSuma = 0;

		for (int intInicial = 0; intInicial < strCadena.length(); intInicial = intFinal + 1) {
			intFinal = strCadena.indexOf(" ", intInicial);
			
			try {
				strAux = strCadena.substring(intInicial, intFinal);
			} catch (StringIndexOutOfBoundsException sie) {
				strAux = strCadena.substring(intInicial, strCadena.length());
				intFinal = strCadena.length();
			}
			
			try {
				intSuma += Integer.parseInt(strAux);
			} catch (NumberFormatException e) {
				System.out.println("Error al pasar a entero: " + e.getMessage());
			}
		}
		System.out.println(intSuma);
	}
}