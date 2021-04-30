package practica.ejercicio2;

import java.util.ArrayList;
import java.util.List;

public class Palabra {
	private String strPalabra, strIdioma;
	private List<Palabra> liSignificados;

	public Palabra() {
		this.strPalabra = "";
		this.strIdioma = "";
		this.liSignificados = new ArrayList<Palabra>();
	}

	public Palabra(String strPalabra, String strIdioma) {
		this.strPalabra = strPalabra;
		this.strIdioma = strIdioma;
		this.liSignificados = new ArrayList<Palabra>();
	}

	public Palabra(String strPalabra, String strIdioma, List<Palabra> liSignificados) {
		this.strPalabra = strPalabra;
		this.strIdioma = strIdioma;
		this.liSignificados = liSignificados;
	}

	public Palabra(String strPalabra, String strIdioma, Palabra objPalabra) {
		this.strPalabra = strPalabra;
		this.strIdioma = strIdioma;
		this.liSignificados = new ArrayList<Palabra>();

		agregarSignificado(objPalabra);
	}

	/**
	 * Busca en la lista de significados la palabra dada
	 * 
	 * @param objPalabra
	 * @return
	 */
	public Palabra sinonimos(String strPalabra) {
		for (Palabra objSignificado : liSignificados) {
			if (objSignificado.getStrPalabra().equals(strPalabra))
				return this;
		}

		return null;
	}

	public String getStrPalabra() {
		return strPalabra;
	}

	public List<Palabra> getLiSignificados() {
		return liSignificados;
	}

	public String getStrIdioma() {
		return strIdioma;
	}

	public void agregarSignificado(Palabra objPalabra) {
		liSignificados.add(objPalabra);
	}

	public void agregarSignificado(List<Palabra> liPalabra) {
		for (Palabra objPalabra : liPalabra)
			liSignificados.add(objPalabra);
	}

	@Override
	public String toString() {
		String toString = "*- " + strPalabra + ", Idioma: " + strIdioma + ", Significados: {\n";
		for (Palabra palabra : liSignificados)
			toString += "    -" + palabra.getStrPalabra() + "\n";

		toString += "}";
		return toString;
	}

}
