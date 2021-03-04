package examen.ejercicio2;

public class DNIExepcion extends Exception{
	private String strMensaje;
	
	
	public DNIExepcion() {
		this.strMensaje = "DNI 9 dígitos";
		}
	
	public String getMessage() {
		return strMensaje;
	}
}
