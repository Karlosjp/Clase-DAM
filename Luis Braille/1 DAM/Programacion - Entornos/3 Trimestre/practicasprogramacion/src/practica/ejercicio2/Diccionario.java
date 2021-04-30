package practica.ejercicio2;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Diccionario {
	HashMap<String, Palabra> hmPalabras;

	public Diccionario() {
		hmPalabras = new HashMap<String, Palabra>();
	}

	public Diccionario(HashMap<String, Palabra> hmPalabras) {
		this.hmPalabras = hmPalabras;
	}

	public Diccionario(List<Palabra> hmPalabras) {
		this.hmPalabras = new HashMap<>();
		for (Palabra objPalabra : hmPalabras) {
			annadirPalabra(objPalabra);
		}
	}

	/**
	 * Agrega una nueva palabra al diccionario
	 * 
	 * @param objNuevaPalabra
	 * @return si la a agregado true si no false
	 */
	public boolean annadirPalabra(Palabra objNuevaPalabra) {
		if (!hmPalabras.containsKey(objNuevaPalabra.getStrPalabra())) {
			hmPalabras.put(objNuevaPalabra.getStrPalabra(), objNuevaPalabra);

			return true;
		}

		return false;
	}

	/**
	 * Comprueba si existe la palabra seleccionada.
	 * 
	 * @param strPalabra
	 * @return true o false
	 */
	public Palabra existePalabra(String strPalabra) {
		return hmPalabras.get(strPalabra);
	}

	/**
	 * Por cada palabra en el diccionario, busca un sinonimo
	 * 
	 * @param strPalabra
	 * @return una lista de palabras o null
	 */
	public List<String> buscarSinonimos(Palabra objPalabra) {
		List<String> liPalabras = new ArrayList<String>();
		Palabra auxPalabra;
		for (Map.Entry<String, Palabra> entry : hmPalabras.entrySet())
			for (Palabra objSignificado : objPalabra.getLiSignificados()) {
				auxPalabra = null;
				if (entry.getKey() != objPalabra.getStrPalabra())
					auxPalabra = entry.getValue().sinonimos(objPalabra.getStrPalabra());

				if (auxPalabra != null)
					liPalabras.add(auxPalabra.getStrPalabra());
			}

		return liPalabras;
	}

	/**
	 * Recibe una lista de palabras sinonimas y el significado que las une
	 * 
	 * @param liSinonimos
	 * @param objSignificado
	 */
	public void agregarSignificado(Palabra objSignificado, String strPalabra) {
		hmPalabras.get(strPalabra).agregarSignificado(objSignificado);
	}

	public void agregarSignificados(List<Palabra> objSignificados, String strPalabra) {
		hmPalabras.get(strPalabra).agregarSignificado(objSignificados);
	}

	@Override
	public String toString() {
		String toString = "Diccionario [Palabras: ";

		for (Map.Entry<String, Palabra> entry : hmPalabras.entrySet())
			toString += entry.getValue() + "\n";

		return toString;
	}
}
