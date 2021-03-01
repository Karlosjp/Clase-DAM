package Ejercicios_profesor.ejercicio5;

public class DefinoExcepcion  extends Exception {
	String strMensaje;
	
	public DefinoExcepcion(String strMsj) {
		this.strMensaje = strMsj;
		}
	
	public String getMessage() {
		return strMensaje;
	}
}