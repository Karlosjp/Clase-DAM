package almacenar;

public class Serie {
	private String strTitulo, strGenero, strCreador;
	private boolean booEntregado;
	private int intTemporada;
	
	public Serie() {
		strCreador = "";
		strGenero = "";
		strTitulo = "";
		booEntregado = false;
		intTemporada = 3;
	}
	
	/**
	 * 
	 * @param strTitulo titulo de la serie
	 * @param strCreador creador de la serie
	 */
	public Serie(String strTitulo, String strCreador) {
		this.strCreador = strCreador;
		strGenero = "";
		this.strTitulo = strTitulo;
		booEntregado = false;
		intTemporada = 3;
	}
	
	/**
	 * @param strTitulo titulo de la serie
	 * @param strCreador Creador de la serie
	 * @param strGenero Genero de la serie
	 * @param intTemporada Numero de temporadas de la serie
	 */
	public Serie(String strTitulo, String strCreador, String strGenero, int intTemporada) {
		this.strCreador = strCreador;
		this.strGenero = strGenero;
		this.strTitulo = strTitulo;
		booEntregado = false;
		intTemporada = intTemporada;
	}
	
	/**
	 * @param strTitulo
	 */
	public void setStrTitulo(String strTitulo) {
		this.strTitulo = strTitulo;
	}
	
	public String toString() {
		return "Titulo: " + strTitulo + ", Genero: " + strGenero + ", Creador: " + strCreador + ", Temporadas: " + intTemporada;
	}
}
