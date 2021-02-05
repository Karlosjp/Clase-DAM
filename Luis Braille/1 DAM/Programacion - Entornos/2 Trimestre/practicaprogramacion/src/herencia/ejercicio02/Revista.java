package herencia.ejercicio02;

public class Revista extends Publicacion {
	private int intNumero;
	
	public Revista () {
		this.intNumero = 0;
	}
	
	public Revista(int intNumero,String strIsbn,String strTitulo, int intAnhoPublicacion ) {
		super(strIsbn, strTitulo, intAnhoPublicacion);
		this.intNumero = intNumero;
	}
	
	@Override
	public String toString() {
			return "ISBN: " + this.strIsbn + ", título: " + this.strTitulo + ", año de publicación: "
					+ this.intAnhoPublicacion + " " + "(prestado)";
	}
}
