package almacenar;

public class Serie {
	private String strTitulo = "";
	private int intNumTemp = 3;
	private boolean blnEntregado = false;
	private String strGenero = "";
	private String strCreador = "";
	
	public Serie() {

	}

	public Serie(String strTitulo, String strCreador) {
		this.strTitulo = strTitulo;
		this.strCreador = strCreador;
	}

	public Serie(String strTitulo, int intNumTemp, String strGenero, String strCreador) {
		super();
		this.strTitulo = strTitulo;
		this.intNumTemp = intNumTemp;
		this.strGenero = strGenero;
		this.strCreador = strCreador;
	}

	public void setStrTitulo(String strTitulo) {
		this.strTitulo = strTitulo;
	}

	public void setIntNumTemp(int intNumTemp) {
		this.intNumTemp = intNumTemp;
	}
	
	public String toString() {
		return "Titulo: " + this.strTitulo +"\n" 
				+ "Temporadas: "	+ this.intNumTemp +"\n"
				+ "Genero:"		+this.strGenero +"\n"
				+ "Creador:"+		this.strCreador;
	}
}
