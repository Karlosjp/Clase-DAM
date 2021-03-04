package examen.ejercicio2;

public class Persona{
	private String strNombre, strDni;
	private int intEdad;
	
	public Persona(String strDni) throws DNIExepcion {
		this.strNombre = "";
		this.intEdad = 0;
		
		if(strDni.length() != 9) 
			throw new DNIExepcion();
		else
			this.strDni = strDni;
		
	}
	
	
}
