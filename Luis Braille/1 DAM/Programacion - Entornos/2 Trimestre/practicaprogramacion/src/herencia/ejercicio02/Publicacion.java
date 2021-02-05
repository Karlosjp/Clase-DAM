package herencia.ejercicio02;

public abstract class Publicacion {
	protected String strIsbn, strTitulo;
	protected int intAnhoPublicacion;
	
	public Publicacion() {
		this.strIsbn = "";
		this.strTitulo = "";
		this.intAnhoPublicacion = 1970;
	}
	
	public Publicacion(String strIsbn, String strTitulo, int intAnhoPublicacion) {
		this.strIsbn = strIsbn;
		this.strTitulo = strTitulo;
		this.intAnhoPublicacion = intAnhoPublicacion;
	}	
	
	@Override
	public String toString() {
			return "ISBN: " + this.strIsbn + ", título: " + this.strTitulo + ", año de publicación: "
					+ this.intAnhoPublicacion;
	}
}
